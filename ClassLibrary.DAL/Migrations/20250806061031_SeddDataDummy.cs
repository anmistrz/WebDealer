using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DealerApi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeddDataDummy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "CarID", "BasePrice", "CarModel", "CarType", "Color", "Description", "EngineSize", "FuelType", "Make", "Transmission", "Year" },
                values: new object[,]
                {
                    { 1, 650000000m, "Pajero Sport", "SUV", "White", "Mitsubishi Pajero Sport, kuat dan nyaman untuk petualangan.", "2.4L", "Diesel", "Mitsubishi", "Automatic", null },
                    { 2, 270000000m, "Xpander", "MPV", "Black", "Mitsubishi Xpander, mobil keluarga dengan desain modern.", "1.5L", "Gasoline", "Mitsubishi", "Automatic", null },
                    { 3, 550000000m, "Outlander", "SUV", "Silver", "Mitsubishi Outlander, stylish dan elegan.", "2.3L", "Gasoline", "Mitsubishi", "Automatic", null }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "Address", "CreatedAt", "District", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Province", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 1, "123 Main St", new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Central Jakarta", "jhonDoe@gmail.com", "John", "Doe", "password123", "08123456789", "Jakarta", null, "johndoe" },
                    { 2, "456 Elm St", new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "West Jakarta", "anistiachan04@gmail.com", "Anistia", "Chan", "password123", "08123456789", "Jakarta", null, "anistiachan" }
                });

            migrationBuilder.InsertData(
                table: "Dealer",
                columns: new[] { "DealerID", "Address", "City", "CreatedAt", "DealerName", "Email", "Location", "PhoneNumber", "Province", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Jl. Sudirman No. 1", "Jakarta", new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Mitsubishi Dealer Jakarta", "mitsubishiJakarta@gmail.com", "Jakarta", "021-12345678", "DKI Jakarta", null },
                    { 2, "Jl. Diponegoro No. 2", "Surabaya", new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Mitsubishi Dealer Surabaya", "mitsubishiSby@gmail.com", "Surabaya", "031-87654321", "Jawa Timur", null }
                });

            migrationBuilder.InsertData(
                table: "DealerCar",
                columns: new[] { "DealerCarID", "CarID", "DealerID", "DealerPrice", "Status", "Stock", "Tax" },
                values: new object[,]
                {
                    { 1, 1, 1, 700000000m, "Available", 5, null },
                    { 2, 2, 1, 300000000m, "Available", 4, null }
                });

            migrationBuilder.InsertData(
                table: "SalesPerson",
                columns: new[] { "SalesPersonID", "Bonus", "CreatedAt", "DealerID", "Email", "FullName", "IsActive", "Password", "PhoneNumber", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "alicejhonson@gmail.com", "Alice Johnson", true, "password123", "08123456789", null, "alicej" },
                    { 2, null, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "anastasya120720@gmail.com", "Anastasya", true, "password123", "08123456789", null, "anastasya" }
                });

            migrationBuilder.InsertData(
                table: "DealerCarUnit",
                columns: new[] { "DealerCarUnitID", "AddedDate", "Color", "DealerCarID", "Status", "VIN", "YearManufacture" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "White", 1, "TestDrive", "VIN1234567893", null },
                    { 2, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Black", 1, "Available", "VIN0987654321", null },
                    { 3, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Silver", 1, "Available", "VIN1234567891", null },
                    { 4, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Red", 1, "Available", "VIN0987654322", null },
                    { 5, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Blue", 1, "Available", "VIN1234567892", null },
                    { 6, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "White", 2, "TestDrive", "VIN1234567895", null },
                    { 7, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Black", 2, "Available", "VIN0987654323", null },
                    { 8, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Silver", 2, "Available", "VIN1234567894", null },
                    { 9, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Red", 2, "Available", "VIN0987654324", null }
                });

            migrationBuilder.InsertData(
                table: "SalesPersonPerformance",
                columns: new[] { "PerformanceID", "MetricDate", "MetricType", "MetricValue", "Notes", "SalesPersonID" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 12, 12), "Sales", 5.0, "Excellent performance in sales this month.", 1 },
                    { 2, new DateOnly(2023, 12, 12), "Customer Satisfaction", 4.5, "High customer satisfaction ratings.", 2 }
                });

            migrationBuilder.InsertData(
                table: "ConsultHistory",
                columns: new[] { "ConsultHistoryID", "Budget", "ConsultDate", "CustomerID", "DealerCarUnitID", "Note", "SalesPersonID" },
                values: new object[,]
                {
                    { 1, 700000000m, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Interested in Pajero Sport", 1 },
                    { 2, 300000000m, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Looking for Xpander", 2 }
                });

            migrationBuilder.InsertData(
                table: "TestDrive",
                columns: new[] { "TestDriveID", "AppointmentDate", "CustomerID", "DealerCarUnitID", "Note", "SalesPersonID", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Test drive for Pajero Sport", 1, "Pending" },
                    { 2, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Test drive for Xpander", 2, "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Notification",
                columns: new[] { "NotificationID", "ConsultHistoryID", "CreatedAt", "CustomerID", "DealerID", "IsRead", "Message", "NotificationType", "Priority", "SalesPersonID", "TestDriveID" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, false, "Your test drive for Pajero Sport is scheduled.", "TestDrive", 0, 1, 1 },
                    { 2, null, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, false, "Your test drive for Xpander is scheduled.", "TestDrive", 0, 2, 2 },
                    { 3, 1, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, false, "Consultation for Pajero Sport is confirmed.", "Consultation", 0, 1, null },
                    { 4, 2, new DateTime(2023, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, false, "Consultation for Xpander is confirmed.", "Consultation", 0, 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "CarID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DealerCarUnit",
                keyColumn: "DealerCarUnitID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DealerCarUnit",
                keyColumn: "DealerCarUnitID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DealerCarUnit",
                keyColumn: "DealerCarUnitID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DealerCarUnit",
                keyColumn: "DealerCarUnitID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DealerCarUnit",
                keyColumn: "DealerCarUnitID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DealerCarUnit",
                keyColumn: "DealerCarUnitID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DealerCarUnit",
                keyColumn: "DealerCarUnitID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalesPersonPerformance",
                keyColumn: "PerformanceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesPersonPerformance",
                keyColumn: "PerformanceID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ConsultHistory",
                keyColumn: "ConsultHistoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ConsultHistory",
                keyColumn: "ConsultHistoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DealerCar",
                keyColumn: "DealerCarID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TestDrive",
                keyColumn: "TestDriveID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TestDrive",
                keyColumn: "TestDriveID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "CarID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DealerCarUnit",
                keyColumn: "DealerCarUnitID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DealerCarUnit",
                keyColumn: "DealerCarUnitID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesPerson",
                keyColumn: "SalesPersonID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesPerson",
                keyColumn: "SalesPersonID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dealer",
                keyColumn: "DealerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DealerCar",
                keyColumn: "DealerCarID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "CarID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dealer",
                keyColumn: "DealerID",
                keyValue: 1);
        }
    }
}
