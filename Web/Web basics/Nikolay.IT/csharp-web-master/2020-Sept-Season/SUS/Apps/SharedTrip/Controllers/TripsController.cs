﻿using SharedTrip.Services;
using SharedTrip.ViewModels.Trips;
using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Globalization;

namespace SharedTrip.Controllers
{
    public class TripsController : Controller
    {
        private readonly ITripService tripService;

        public TripsController(ITripService tripService)
        {
            this.tripService = tripService;
        }
        public HttpResponse All()
        {
            //var viewModel = tripService.GetAll();
            return this.View();
        }


        public HttpResponse Add()
        {
            return this.View();
        }

        [HttpPost]
        public HttpResponse Add(AddTripsViewModel trip)
        {
            if (string.IsNullOrEmpty(trip.StartPoint))
            {
                return this.Error("Start point can not be empty!");
            }

            if (string.IsNullOrEmpty(trip.EndPoint))
            {
                return this.Error("End point can not be empty!");
            }

            if (string.IsNullOrEmpty(trip.Description) && trip.Description.Length > 80)
            {
                return this.Error("Description can not be empty and should be max 80 symbols!");
            }

            if (trip.Seats < 2 || trip.Seats > 6)
            {
                return this.Error("Seats should be between 2 and 6!");
            }

            if (!DateTime.TryParseExact(trip.DepartureTime, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return this.Error("Invalid departure time!");
            }

            this.tripService.Create(trip);

            return this.Redirect("/Trips/All");
        }

        public HttpResponse Details()
        {
            return this.View();
        }
    }
}