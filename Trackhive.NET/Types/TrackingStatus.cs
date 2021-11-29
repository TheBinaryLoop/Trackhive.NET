namespace Trackhive.NET.Types
{
    public enum TrackingStatus
    {
        Pending,
        InfoReceived,
        InTransit,
        OutForDelivery,
        Delivered,
        Exception,
        FailedAttempt,
        Expired
    }
}
