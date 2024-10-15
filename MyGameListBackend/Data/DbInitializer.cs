using System;
using System.Collections.Generic;
using System.Linq;
using MyGameList.Data;
using MyGameList.Models;

namespace MyGameListBackend.Data
{
    public static class DbInitializar
    {
        public static void Initialize(MyGameListContext context)
        {
            if (context.Users.Any() && context.Tracker.Any() && context.TrackerCategory.Any())
            {
                return;
            }

            // var user = new User[] {
            //     new("Diego", "dipz", "", "", true, new DateTime(), new DateTime(), [
            //         new Tracker(new TrackerCategory("Playing")),
            //         new Tracker(new TrackerCategory("Played")),
            //         new Tracker(new TrackerCategory("Completed 100%")),
            //         new Tracker(new TrackerCategory("Dropped")),
            //     ]),
            //     new("Daniel", "dangtn", "", "", true, new DateTime(), new DateTime(), [
            //         new Tracker(new TrackerCategory("Playing")),
            //         new Tracker(new TrackerCategory("Played")),
            //         new Tracker(new TrackerCategory("Completed 100%")),
            //         new Tracker(new TrackerCategory("Dropped")),
            //     ]),
            //     new("Rodrigo", "oszterr", "", "", true, new DateTime(), new DateTime(), [
            //         new Tracker(new TrackerCategory("Playing")),
            //         new Tracker(new TrackerCategory("Played")),
            //         new Tracker(new TrackerCategory("Completed 100%")),
            //         new Tracker(new TrackerCategory("Dropped")),
            //     ])
            // };
        }
    }
}