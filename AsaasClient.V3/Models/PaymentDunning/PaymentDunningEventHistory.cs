﻿using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.PaymentDunning
{
    public class PaymentDunningEventHistory
    {
        public string Status { get; set; }

        public string Description { get; set; }

        public DateTime EventDate { get; set; }
    }
}
