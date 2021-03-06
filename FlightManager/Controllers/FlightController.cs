﻿using System;
using System.Collections.Generic;
using FlightManager.Models;
using FlightManager.Services;
using FlightManager.BindingModels.Flight;
using FlightManager.ViewModels.Flight;
using FlightManager.ViewModels.Reservation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlightManager.Controllers
{
    public class FlightController : Controller
    {
        private IFlightService flightService;
        private IReservationService reservationService;

        public FlightController(IFlightService flightService, IReservationService reservationService)
        {
            this.flightService = flightService;
            this.reservationService = reservationService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create(Input input)
        {
            return View(input);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(CreateBindingModel input)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/Flight/Create");
            }

            var departureTime = new DateTime();

            if (!DateTime.TryParse(input.DepartureTime, out departureTime))
            {
                return Redirect("/Flight/Create");
            }

            var arrivalTime = new DateTime();

            if (!DateTime.TryParse(input.ArrivalTime, out arrivalTime))
            {
                return Redirect("/Flight/Create");
            }

            if (arrivalTime < departureTime)
            {
                return Redirect("/Flight/Create");
            }

            var flight = new FlightServiceModel
            {
                From = input.From,
                To = input.To,
                ArrivalTime = arrivalTime,
                DepartureTime = departureTime,
                FreePassengersSeats = input.FreePassengersSeats,
                FreeBusinessSeats = input.FreeBusinessSeats,
                PlaneNumber = input.PlaneNumber,
                PlaneType = input.PlaneType,
                PilotName = input.PilotName
            };

            flightService.Create(flight);

            return Redirect("/Home/Index");
        }

        public IActionResult GetAll(int page)
        {
            if (page <= 0)
            {
                return Redirect("/Home/Index");
            }

            int flightsCount = flightService.GetCount();

            var lastPage = flightsCount / GlobalConstants.FlightsPerPage + 1;

            if (flightsCount % GlobalConstants.FlightsPerPage == 0 && lastPage > 1)
            {
                lastPage--;
            }

            if (page > lastPage)
            {
                return Redirect("/Home/Index");
            }

            var flights = flightService.GetAll(page);

            var viewModel = new FlightManager.ViewModels.Flight.ListingPageViewModel
            {
                CurrentPage = page,
                TotalFlightsCount = flightsCount,
                LastPage = lastPage,
                Flights = new List<ListingViewModel>()
            };

            foreach (var flight in flights)
            {
                TimeSpan span = (flight.ArrivalTime - flight.DepartureTime);

                var travelTime = String.Format("{0} days/{1} hours/{2} minutes",
                    span.Days, span.Hours, span.Minutes, span.Seconds);

                viewModel.Flights.Add(new ListingViewModel()
                {
                    From = flight.From,
                    DepartureTime = flight.DepartureTime.ToString(GlobalConstants.DateTimeFormat),
                    To = flight.To,
                    Id = flight.Id,
                    TravelTime = travelTime,
                    FreePassengersSeats = flight.FreePassengersSeats,
                    FreeBusinessSeats = flight.FreeBusinessSeats
                });
            }

            return View(viewModel);
        }

        public IActionResult Details(string id)
        {
            if (!flightService.HasWithId(id))
            {
                return Redirect("/Flight/GetAll?page=1");
            }

            var flight = flightService.GetById(id);
            var reservations = reservationService.GetAllByFlightId(flight.Id);

            var viewModel = new DetailsViewModel()
            {
                Id = flight.Id,
                ArrivalTime = flight.ArrivalTime.ToString(GlobalConstants.DateTimeFormat),
                DepartureTime = flight.DepartureTime.ToString(GlobalConstants.DateTimeFormat),
                FreePassengersSeats = flight.FreePassengersSeats,
                FreeBusinessSeats = flight.FreeBusinessSeats,
                From = flight.From,
                PilotName = flight.PilotName,
                PlaneNumber = flight.PlaneNumber,
                To = flight.To,
                PlaneType = flight.PlaneType
            };

            foreach (var reservation in reservations)
            {
                viewModel.Passengers.Add(new ReservationViewModel
                {
                    SSN = reservation.SSN,
                    Email = reservation.Email,
                    FirstName = reservation.FirstName,
                    LastName = reservation.LastName,
                    Nationality = reservation.Nationality,
                    PhoneNumber = reservation.PhoneNumber,
                    SecondName = reservation.SecondName,
                    TicketType = reservation.TicketType.ToString(),
                    TicketsCount = reservation.TicketsCount
                });
            }

            return View(viewModel);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(string id)
        {
            if (!flightService.HasWithId(id))
            {
                return Redirect("/Flight/GetAll?page=1");
            }

            flightService.DeleteById(id);

            return Redirect("/Flight/GetAll?page=1");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(string id)
        {
            if (!flightService.HasWithId(id))
            {
                return Redirect("/Flight/GetAll?page=1");
            }

            var flight = flightService.GetById(id);

            var viewModel = new DetailsViewModel()
            {
                Id = flight.Id,
                ArrivalTime = flight.ArrivalTime.ToString(GlobalConstants.DateTimeFormat),
                DepartureTime = flight.DepartureTime.ToString(GlobalConstants.DateTimeFormat),
                FreePassengersSeats = flight.FreePassengersSeats,
                FreeBusinessSeats = flight.FreeBusinessSeats,
                From = flight.From,
                PilotName = flight.PilotName,
                PlaneNumber = flight.PlaneNumber,
                To = flight.To,
                PlaneType = flight.PlaneType
            };

            return View(viewModel);
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Edit(Input input)
        {
            if (!ModelState.IsValid)
            {
                return Redirect($"/Flight/Edit?id={input.Id}");
            }

            var departureTime = new DateTime();

            if (!DateTime.TryParse(input.DepartureTime, out departureTime))
            {
                return Redirect($"/Flight/Edit?id={input.Id}");
            }

            var arrivalTime = new DateTime();

            if (!DateTime.TryParse(input.ArrivalTime, out arrivalTime))
            {
                return Redirect($"/Flight/Edit?id={input.Id}");
            }

            if (arrivalTime < departureTime)
            {
                return Redirect($"/Flight/Edit?id={input.Id}");
            }

            var flight = new FlightServiceModel
            {
                Id = input.Id,
                From = input.From,
                To = input.To,
                ArrivalTime = arrivalTime,
                DepartureTime = departureTime,
                FreePassengersSeats = input.FreePassengersSeats,
                FreeBusinessSeats = input.FreeBusinessSeats,
                PlaneNumber = input.PlaneNumber,
                PlaneType = input.PlaneType,
                PilotName = input.PilotName
            };

            flightService.Edit(flight);

            return Redirect("/Flight/GetAll?page=1");
        }
    }
}
