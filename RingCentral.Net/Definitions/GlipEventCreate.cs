namespace RingCentral
{
    public class GlipEventCreate
    {
        /// <summary>
        /// Internal identifier of an event
        /// </summary>
        public string id;

        /// <summary>
        /// Internal identifier of a person created an event
        /// </summary>
        public string creatorId;

        /// <summary>
        /// Event title
        /// Required
        /// </summary>
        public string title;

        /// <summary>
        /// Datetime of starting an event
        /// Required
        /// </summary>
        public string startTime;

        /// <summary>
        /// Datetime of ending an event
        /// Required
        /// </summary>
        public string endTime;

        /// <summary>
        /// Indicates whether event has some specific time slot or lasts for whole day(s)
        /// </summary>
        public bool? allDay;

        /// <summary>
        /// Event recurrence settings. For non-periodic events the value is 'None'. Must be greater or equal to event duration: 1- Day/Weekday; 7 - Week; 28 - Month; 365 - Year
        /// Enum: None, Day, Weekday, Week, Month, Year
        /// </summary>
        public string recurrence;

        /// <summary>
        /// Condition of ending
        /// </summary>
        public string endingCondition;

        /// <summary>
        /// Count of iterations. For periodic events only. Value range is 1 - 10. Must be specified if 'endingCondition' is 'Count'
        /// </summary>
        public long? endingAfter;

        /// <summary>
        /// Iterations end datetime for periodic events.
        /// Default: None
        /// Enum: None, Count, Date
        /// </summary>
        public string endingOn;

        /// <summary>
        /// Color of Event title (including its presentation in Calendar)
        /// Default: Black
        /// Enum: Black, Red, Orange, Yellow, Green, Blue, Purple, Magenta
        /// </summary>
        public string color;

        /// <summary>
        /// Event location
        /// </summary>
        public string location;

        /// <summary>
        /// Event details
        /// </summary>
        public string description;
    }
}