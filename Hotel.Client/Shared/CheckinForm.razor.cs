﻿using Hotel.Client.Toast;
using Hotel.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Hotel.Client.Shared
{
    public partial class CheckinForm
    {
        [Parameter] public RoomAvailabilityRequest AvailableRoom { get; set; }
        [Parameter] public EventCallback EventCallback { get; set; }
        [Inject] AppState AppState { get; set; }
        [Inject] HttpClient Http { get; set; }
        [Inject] IConfiguration Configuration { get; set; }
        [Inject] NavigationManager Nav { get; set; }

        private List<int> numberOfGuest = new List<int> { 1, 2, 3, 4 };
        [Inject] ToastService Toast { get; set; }
        private RoomInfo[] Rooms { get; set; } // todo: pass this data to next component to show rooms
    }
}
