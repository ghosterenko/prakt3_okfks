using CinemaTicketSystem;
namespace pr3_konkov
{
    public class TicketTest
    {
        [Fact]
        public void CheckStandartTicketWithoutDiscount()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 30;
            request.IsStudent = false;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 300;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckKidsTicket()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 11;
            request.IsStudent = false;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 180;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckStudentTicket()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 20;
            request.IsStudent = true;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 240;
            Assert.Equal(result, calc.CalculatePrice(request));
            
        }
        [Fact]
        public void CheckPrnsionerTicket()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 70;
            request.IsStudent = false;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 150;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckMorningForDiscount()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 30;
            request.IsStudent = false;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(11);
            decimal result = 255;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckDiscountForWednesday()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 30;
            request.IsStudent = false;
            request.IsVip = false;
            request.Day = DayOfWeek.Wednesday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 210;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckVipTicket()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 30;
            request.IsStudent = false;
            request.IsVip = true;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 600;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckMoreDiscountForChildTicket()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 10;
            request.IsStudent = false;
            request.IsVip = false;
            request.Day = DayOfWeek.Wednesday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 180;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckMoreDiscountForStudentTicket()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 20;
            request.IsStudent = true;
            request.IsVip = false;
            request.Day = DayOfWeek.Wednesday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 210;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckMoreDiscountForStudentPlusVipTicket()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 20;
            request.IsStudent = true;
            request.IsVip = true;
            request.Day = DayOfWeek.Wednesday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 420;
            Assert.Equal(result, calc.CalculatePrice(request));
        }


        [Fact]
        public void CheckBorderMinimulValidAge()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 0;
            request.IsStudent = false;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 0;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckBorderMaximumValidAge()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 120;
            request.IsStudent = false;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 150;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckBorderForAge5Child()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 5;
            request.IsStudent = false;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 0;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckBorderForAge18Student()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 18;
            request.IsStudent = true;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 240;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckBorderForAge25Student()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 25;
            request.IsStudent = true;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 240;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckBorderForAge64()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = 64;
            request.IsStudent = false;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            decimal result = 300;
            Assert.Equal(result, calc.CalculatePrice(request));
        }
        [Fact]
        public void CheckExeptionNull()
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest? request = null;
            Assert.Throws<ArgumentNullException>(() => calc.CalculatePrice(request));
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(121)]
        public void CheckBorderForAgeMinus1And121(int age)
        {
            TicketPriceCalculator calc = new TicketPriceCalculator();
            TicketRequest request = new TicketRequest();
            request.Age = age;
            request.IsStudent = false;
            request.IsVip = false;
            request.Day = DayOfWeek.Monday;
            request.SessionTime = TimeSpan.FromHours(15);
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => calc.CalculatePrice(request));
            Assert.Contains("Возраст должен быть от 0 до 120", ex.Message.ToString());
        }
    }
}