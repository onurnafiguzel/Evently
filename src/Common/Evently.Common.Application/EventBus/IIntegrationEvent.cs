﻿namespace Evently.Common.Application.EventBus;
public interface IIntegrationEvent
{
    Guid Id { get; }
    DateTime OccuredOnUtc { get; }
}
