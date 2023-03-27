﻿using System;
using System.Collections.Generic;

namespace EntityFrame.Entities;

public partial class PatientTest
{
    public Guid Id { get; set; }

    public string? HealthId { get; set; }

    public string? AppointmentId { get; set; }

    public string? Test { get; set; }

    public string? Result { get; set; }

    public virtual PatientHealthRecord? Appointment { get; set; }
}
