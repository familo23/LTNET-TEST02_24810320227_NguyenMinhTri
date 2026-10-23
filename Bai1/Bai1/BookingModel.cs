using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bai1
{
    public sealed class BookingModel : INotifyPropertyChanged
    {
        private string bookingId = string.Empty;
        private string customerName = string.Empty;
        private string identityCard = string.Empty;
        private string roomType = string.Empty;
        private DateTime checkInDate;
        private int numberOfNights;
        private decimal pricePerNight;

        public string BookingId
        {
            get => bookingId;
            set => SetField(ref bookingId, value);
        }

        public string CustomerName
        {
            get => customerName;
            set => SetField(ref customerName, value);
        }

        public string IdentityCard
        {
            get => identityCard;
            set => SetField(ref identityCard, value);
        }

        public string RoomType
        {
            get => roomType;
            set => SetField(ref roomType, value);
        }

        public DateTime CheckInDate
        {
            get => checkInDate;
            set => SetField(ref checkInDate, value);
        }

        public int NumberOfNights
        {
            get => numberOfNights;
            set => SetField(ref numberOfNights, value);
        }

        public decimal PricePerNight
        {
            get => pricePerNight;
            set => SetField(ref pricePerNight, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return;
            }

            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
