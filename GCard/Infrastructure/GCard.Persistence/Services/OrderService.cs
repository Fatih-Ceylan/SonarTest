﻿using GCard.Application.Abstractions.Services.Order;
using GCard.Application.Repositories.ReadRepository;
using GCard.Application.Repositories.WriteRepository;
using Utilities.Core.UtilityApplication.Enums;

namespace GCard.Persistence.Services
{
    public class OrderService : IOrderService
    {
        readonly IOrderReadRepository _orderReadRepository;
        readonly IOrderWriteRepository _orderWriteRepository;

        public OrderService(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
        }

        public async Task<bool> UpdateOrderStatus(string orderId, OrderStatus status)
        {

            var order = await _orderReadRepository.GetByIdAsync(orderId);
            order.Status = status;

            await _orderWriteRepository.SaveAsync();

            return true;
        }

        public async Task<bool> UpdateCargoTrackingNo(string orderId, string cargoTrackingNo)
        {

            var order = await _orderReadRepository.GetByIdAsync(orderId);
            order.CargoTrackingNo = cargoTrackingNo;

            await _orderWriteRepository.SaveAsync();

            return true;
        }
    }
}