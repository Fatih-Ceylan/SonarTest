﻿namespace GCharge.Application.Features.Commands.Definitions.ElectricitySalesPrice.Update
{
    public class UpdateElectricitySalesPriceResponse
    {
        public string Id { get; set; }
        public string? ChargePointId { get; set; }

        public string Title { get; set; }
        public decimal PricePerKWh { get; set; }
        public int VatRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsDefault { get; set; }

        public string Message { get; set; }
    }
}
