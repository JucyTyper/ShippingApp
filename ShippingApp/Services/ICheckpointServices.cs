﻿using ShippingApp.Models;

namespace ShippingApp.Services
{
    public interface ICheckpointServices
    {
        public ResponseModel addCheckpoint(AddCheckpointModel checkpoint);
    }
}
