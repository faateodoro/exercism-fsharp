module BookingUpForBeauty

open System

let schedule (appointmentDateDescription: string): DateTime = 
    DateTime.Parse appointmentDateDescription

let hasPassed (appointmentDate: DateTime): bool = 
    appointmentDate < DateTime.Now

let isAfternoonAppointment (appointmentDate: DateTime): bool =
    let appointment = appointmentDate.TimeOfDay
    let isAfternoon t = t >= TimeSpan.Parse "12:00" && t < TimeSpan.Parse "18:00"
    
    match appointment with
    | t when isAfternoon t -> true
    | _ -> false


let description (appointmentDate: DateTime): string = 
    let appointmentDescription = appointmentDate.ToString("G")
    $"You have an appointment on {appointmentDescription}." 

let anniversaryDate(): DateTime = 
    DateTime(DateTime.Now.Year, 9, 15)