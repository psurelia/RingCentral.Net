namespace RingCentral
{
    public class ConferencePhoneNumberInfo : Serializable
    {
        // Dial-in phone number to connect to a conference
        public string phoneNumber;
        // 'True' if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
        public bool? @default;
    }
}