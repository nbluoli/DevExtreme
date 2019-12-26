﻿using DevExtreme.NETCore.Demos.Models.SampleData;
using DevExtreme.NETCore.Demos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtreme.NETCore.Demos.Controllers {
    public class SchedulerController : Controller {
        public ActionResult SimpleArray() {
            return View();
        }

        public ActionResult Adaptability() {
            return View(new AdaptabilityAppointmentViewModel {
                Appointments = SampleData.AdaptabilityAppointments,
                Priorities = SampleData.PriorityResources
            });
        }

        public ActionResult WebAPIService() {
            return View();
        }

        public ActionResult Overview() {
            return View(SampleData.Workouts);
        }

        public ActionResult BasicViews() {
            return View(SampleData.Appointments);
        }

        public ActionResult Agenda() {
            return View(SampleData.AgendaTasks);
        }

        public ActionResult RecurringAppointments() {
            return View(new RecurringAppointmentsViewModel {
                Appointments = SampleData.RecurringAppointments,
                Resources = SampleData.RecurringAppointmentsResources
            });
        }

        public ActionResult GroupOrientation() {
            return View(SampleData.Tasks);
        }

        public ActionResult GroupByDate() {
            return View(SampleData.GroupByDateTasks);
        }

        public ActionResult Timelines() {
            return View(SampleData.TimelineTasks);
        }

        public ActionResult GoogleCalendarIntegration() {
            return View();
        }

        public ActionResult CustomTemplates() {
            return View(new SchedulerViewModel {
                CinemaData = SampleData.CinemaData,
                Movies = SampleData.Movies,
                Theatres = SampleData.Theatres
            });
        }

        public ActionResult TimeZonesSupport() {
            return View(SampleData.Events);
        }

        public ActionResult Resources() {
            return View(new SchedulerResourcesViewModel {
                Appointments = SampleData.AppointmentsWithResources,
                Owners = SampleData.OwnerResources,
                Rooms = SampleData.RoomResources,
                Priorities = SampleData.PriorityResources
            });
        }

        public ActionResult Editing() {
            return View(SampleData.Appointments);
        }

        public ActionResult CellTemplates() {
            return View(SampleData.Workouts);
        }

        public ActionResult CustomizeIndividualViews() {
            return View(SampleData.Jobs);
        }

        public ActionResult IncreaseViewDuration() {
            return View(SampleData.PlannedTasks);
        }

        public ActionResult LimitAppointmentCountPerCell() {
            return View(new LimitAppointmentCountPerCellModel {
                Appointments = SampleData.AdaptiveAppointments,
                Resources = SampleData.AdaptiveAppointmentsResources
            });
        }

        public ActionResult CurrentTimeIndicator() {
            return View(new DynamicAppointmentsViewModel {
                Appointments = SampleData.DynamicAppointments,
                Resources = SampleData.DynamicAppointmentsResources
            });
        }

        public ActionResult ContextMenuIntegration() {
            return View(new AppointmentContextMenuItemsViewModel {
                Appointments = SampleData.RecurringAppointments,
                Resources = SampleData.RecurringAppointmentsResources,
                ContextMenuItems = SampleData.AppointmentContextMenuItems
            });
        }

        public ActionResult SignalRService() {
            return View();
        }
    }
}