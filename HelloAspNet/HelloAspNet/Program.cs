var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss"));

var yers = DateTime.Now.Year;
int temp;

if (DateTime.IsLeapYear(yers))
{
    temp = 366 - DateTime.Now.DayOfYear;
}
else
{
    temp = 365 - DateTime.Now.DayOfYear;
}


app.MapGet("/", () => "Дней до нового года:" + " " +  temp);

app.Run();