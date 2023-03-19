﻿namespace PMGD_MarketPlace.Server.Models {
    public class Order {
        public int Uid { get; set; }
        public string Timestamp { get; set; }
        public Product Product { get; set; } = new();
        public Visitor Visitor { get; set; } = new();
    }
}
                                                