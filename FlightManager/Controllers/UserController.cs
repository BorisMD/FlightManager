﻿using System.Collections.Generic;
using FlightManager.Models;
using FlightManager.Services;
using FlightManager.BindingModels.User;
using FlightManager.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlightManager.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult All(int page, int showBy, string orderBy)
        {
            if (page <= 0)
            {
                return Redirect("/Home/Index");
            }

            int usersCount = userService.GetCount();

            if (showBy <= 0)
            {
                return Redirect("/Home/Index");
            }

            var lastPage = usersCount / showBy + 1;

            if (usersCount % showBy == 0 && lastPage > 1)
            {
                lastPage--;
            }

            if (page > lastPage)
            {
                return Redirect("/Home/Index");
            }

            var users = userService.GetAll(page, showBy, orderBy);

            var viewModel = new ListingPageViewModel
            {
                CurrentPage = page,
                TotalUsersCount = usersCount,
                UsersPerPage = showBy,
                LastPage = lastPage,
                OrderParam = "orderBy=" + orderBy,
                Users = new List<ListingViewModel>()
            };

            foreach (var user in users)
            {
                viewModel.Users.Add(new ListingViewModel()
                {
                    Username = user.UserName,
                    Address = user.Address,
                    SSN = user.SSN,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    Id = user.Id,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber
                });
            }

            return View(viewModel);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(string id)
        {
            if (!userService.Contains(id))
            {
                return Redirect("/User/All?page=1&showBy=10&orderBy=usernameAsc");
            }

            var user = userService.GetById(id);

            var viewModel = new EditBindingModel
            {
                Address = user.Address,
                SSN = user.SSN,
                FirstName = user.FirstName,
                Id = user.Id,
                LastName = user.LastName
            };

            return View(viewModel);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Edit(EditBindingModel input)
        {
            if (!userService.Contains(input.Id))
            {
                return Redirect("/User/All?page=1&showBy=10&orderBy=usernameAsc");
            }

            if (!ModelState.IsValid)
            {
                return Redirect("/User/All?page=1&showBy=10&orderBy=usernameAsc");
            }

            var serviceModel = new UserServiceModel
            {
                Address = input.Address,
                SSN = input.SSN,
                FirstName = input.FirstName,
                Id = input.Id,
                LastName = input.LastName
            };

            userService.Edit(serviceModel);

            return Redirect("/User/All?page=1&showBy=10&orderBy=usernameAsc");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(string id)
        {
            if (!userService.Contains(id))
            {
                return Redirect("/User/All?page=1&showBy=10&orderBy=usernameAsc");
            }

            userService.Delete(id);

            return Redirect("/User/All?page=1&showBy=10&orderBy=usernameAsc");
        }

    }
}
