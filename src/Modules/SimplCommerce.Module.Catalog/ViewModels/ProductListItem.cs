﻿using System;

namespace SimplCommerce.Module.Catalog.ViewModels
{
    public class ProductListItem
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool HasOptions { get; set; }

        public bool IsVisibleIndividually { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public bool IsPublished { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsCallForPricing { get; set; }

        public bool IsAllowToOrder { get; set; }

        public int? StockQuantity { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public DateTimeOffset? DepartureDate { get; set; }

        public DateTimeOffset? LandingDate { get; set; }

        public string Status { get; set; }

        public string Provider { get; set; }

    }
}
