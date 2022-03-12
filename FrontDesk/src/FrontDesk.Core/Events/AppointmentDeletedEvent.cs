using System;
using FrontDesk.Core.ScheduleAggregate;
using PluralsightDdd.SharedKernel;

namespace FrontDesk.Core.Events
{
  public class AppointmentDeletedEvent : BaseDomainEvent
  {
    public AppointmentDeletedEvent(Appointment appointment)
    {
      appointmentDeleted = appointment;
      Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }

    public Appointment appointmentDeleted { get; private set;}
  }
}
