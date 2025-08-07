using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealerApi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrateWithIdentityUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    CarModel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CarType = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    EngineSize = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FuelType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Transmission = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Color = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BasePrice = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Car__68A0340E7BA04DD0", x => x.CarID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    isGuest = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    District = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Province = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(sysutcdatetime())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__A4AE64B81043A2F1", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Dealer",
                columns: table => new
                {
                    DealerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Province = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(sysutcdatetime())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Dealer__CA2F8E920C5A5183", x => x.DealerID);
                });

            migrationBuilder.CreateTable(
                name: "LetterOfIntent",
                columns: table => new
                {
                    LoiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FixPrice = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    DownPayment = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LetterOf__412C029A7FB45EFB", x => x.LoiID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DealerCar",
                columns: table => new
                {
                    DealerCarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerID = table.Column<int>(type: "int", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    DealerPrice = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true, defaultValue: "Available")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DealerCa__7DD0B566EC9EB396", x => x.DealerCarID);
                    table.ForeignKey(
                        name: "FK__DealerCar__CarID__440B1D61",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "CarID");
                    table.ForeignKey(
                        name: "FK__DealerCar__Deale__4316F928",
                        column: x => x.DealerID,
                        principalTable: "Dealer",
                        principalColumn: "DealerID");
                });

            migrationBuilder.CreateTable(
                name: "SalesPerson",
                columns: table => new
                {
                    SalesPersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerID = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(sysutcdatetime())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SalesPer__7A591C18AFAF1804", x => x.SalesPersonID);
                    table.ForeignKey(
                        name: "FK__SalesPers__Deale__4E88ABD4",
                        column: x => x.DealerID,
                        principalTable: "Dealer",
                        principalColumn: "DealerID");
                });

            migrationBuilder.CreateTable(
                name: "DealerCarUnit",
                columns: table => new
                {
                    DealerCarUnitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerCarID = table.Column<int>(type: "int", nullable: false),
                    VIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    YearManufacture = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValue: "Available"),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysutcdatetime())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DealerCa__28B4C5F22AB18DDB", x => x.DealerCarUnitID);
                    table.ForeignKey(
                        name: "FK__DealerCar__Deale__49C3F6B7",
                        column: x => x.DealerCarID,
                        principalTable: "DealerCar",
                        principalColumn: "DealerCarID");
                });

            migrationBuilder.CreateTable(
                name: "WarrantyRegistration",
                columns: table => new
                {
                    WarrantyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerCarID = table.Column<int>(type: "int", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Warranty__2ED318F318F9F63B", x => x.WarrantyID);
                    table.ForeignKey(
                        name: "FK__WarrantyR__Deale__1BC821DD",
                        column: x => x.DealerCarID,
                        principalTable: "DealerCar",
                        principalColumn: "DealerCarID");
                });

            migrationBuilder.CreateTable(
                name: "Agreement",
                columns: table => new
                {
                    AgreementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerCarID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    SalesPersonID = table.Column<int>(type: "int", nullable: false),
                    LoiID = table.Column<int>(type: "int", nullable: false),
                    MethodPayment = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: "Credit"),
                    BookingFee = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    AgreementDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Agreemen__0A309D231A386255", x => x.AgreementID);
                    table.ForeignKey(
                        name: "FK__Agreement__Custo__7F2BE32F",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK__Agreement__Deale__01142BA1",
                        column: x => x.DealerCarID,
                        principalTable: "DealerCar",
                        principalColumn: "DealerCarID");
                    table.ForeignKey(
                        name: "FK__Agreement__LoiID__02084FDA",
                        column: x => x.LoiID,
                        principalTable: "LetterOfIntent",
                        principalColumn: "LoiID");
                    table.ForeignKey(
                        name: "FK__Agreement__Sales__00200768",
                        column: x => x.SalesPersonID,
                        principalTable: "SalesPerson",
                        principalColumn: "SalesPersonID");
                });

            migrationBuilder.CreateTable(
                name: "SalesPersonPerformance",
                columns: table => new
                {
                    PerformanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesPersonID = table.Column<int>(type: "int", nullable: false),
                    MetricType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MetricValue = table.Column<double>(type: "float", nullable: false),
                    MetricDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SalesPer__F9606DE1BBC4F70E", x => x.PerformanceID);
                    table.ForeignKey(
                        name: "FK__SalesPers__Sales__52593CB8",
                        column: x => x.SalesPersonID,
                        principalTable: "SalesPerson",
                        principalColumn: "SalesPersonID");
                });

            migrationBuilder.CreateTable(
                name: "ConsultHistory",
                columns: table => new
                {
                    ConsultHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    DealerCarUnitID = table.Column<int>(type: "int", nullable: false),
                    SalesPersonID = table.Column<int>(type: "int", nullable: true),
                    Budget = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    ConsultDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ConsultH__C5DB29E8E7681CCB", x => x.ConsultHistoryID);
                    table.ForeignKey(
                        name: "FK__ConsultHi__Custo__59FA5E80",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK__ConsultHi__Deale__5AEE82B9",
                        column: x => x.DealerCarUnitID,
                        principalTable: "DealerCarUnit",
                        principalColumn: "DealerCarUnitID");
                    table.ForeignKey(
                        name: "FK__ConsultHi__Sales__5BE2A6F2",
                        column: x => x.SalesPersonID,
                        principalTable: "SalesPerson",
                        principalColumn: "SalesPersonID");
                });

            migrationBuilder.CreateTable(
                name: "LoiCarFromDealer",
                columns: table => new
                {
                    LoiID = table.Column<int>(type: "int", nullable: false),
                    DealerCarUnitID = table.Column<int>(type: "int", nullable: false),
                    TotalUnit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LoiCarFr__73A74EC5A0FD1B97", x => new { x.LoiID, x.DealerCarUnitID });
                    table.ForeignKey(
                        name: "FK__LoiCarFro__Deale__797309D9",
                        column: x => x.DealerCarUnitID,
                        principalTable: "DealerCarUnit",
                        principalColumn: "DealerCarUnitID");
                    table.ForeignKey(
                        name: "FK__LoiCarFro__LoiID__787EE5A0",
                        column: x => x.LoiID,
                        principalTable: "LetterOfIntent",
                        principalColumn: "LoiID");
                });

            migrationBuilder.CreateTable(
                name: "TestDrive",
                columns: table => new
                {
                    TestDriveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    DealerCarUnitID = table.Column<int>(type: "int", nullable: false),
                    SalesPersonID = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: "Pending"),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TestDriv__BF98EF72A6CC429C", x => x.TestDriveID);
                    table.ForeignKey(
                        name: "FK__TestDrive__Custo__5535A963",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK__TestDrive__Deale__5629CD9C",
                        column: x => x.DealerCarUnitID,
                        principalTable: "DealerCarUnit",
                        principalColumn: "DealerCarUnitID");
                    table.ForeignKey(
                        name: "FK__TestDrive__Sales__571DF1D5",
                        column: x => x.SalesPersonID,
                        principalTable: "SalesPerson",
                        principalColumn: "SalesPersonID");
                });

            migrationBuilder.CreateTable(
                name: "WarrantyClaim",
                columns: table => new
                {
                    ClaimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarrantyID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ClaimStatus = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValueSql: "(NULL)"),
                    CostCovered = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ClaimDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Warranty__EF2E13BBC5E8A1B3", x => x.ClaimID);
                    table.ForeignKey(
                        name: "FK__WarrantyC__Custo__2180FB33",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK__WarrantyC__Warra__208CD6FA",
                        column: x => x.WarrantyID,
                        principalTable: "WarrantyRegistration",
                        principalColumn: "WarrantyID");
                });

            migrationBuilder.CreateTable(
                name: "AgreementUnit",
                columns: table => new
                {
                    AgreementUnitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgreementID = table.Column<int>(type: "int", nullable: false),
                    DealerCarUnitID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Agreemen__3F6CC47871B29A00", x => x.AgreementUnitID);
                    table.ForeignKey(
                        name: "FK__Agreement__Agree__04E4BC85",
                        column: x => x.AgreementID,
                        principalTable: "Agreement",
                        principalColumn: "AgreementID");
                    table.ForeignKey(
                        name: "FK__Agreement__Deale__05D8E0BE",
                        column: x => x.DealerCarUnitID,
                        principalTable: "DealerCarUnit",
                        principalColumn: "DealerCarUnitID");
                });

            migrationBuilder.CreateTable(
                name: "CreditApplication",
                columns: table => new
                {
                    CreditAppID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgreementID = table.Column<int>(type: "int", nullable: true),
                    TimePeriod = table.Column<int>(type: "int", nullable: true),
                    PaymentMade = table.Column<int>(type: "int", nullable: true),
                    InterestRate = table.Column<double>(type: "float", nullable: true),
                    InstallmentPerMonth = table.Column<int>(type: "int", nullable: true),
                    ApprovalStatus = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: "Pending"),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CreditAp__5F45706C4EE230F9", x => x.CreditAppID);
                    table.ForeignKey(
                        name: "FK__CreditApp__Agree__123EB7A3",
                        column: x => x.AgreementID,
                        principalTable: "Agreement",
                        principalColumn: "AgreementID");
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    PurchaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Nominal = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    AgreementID = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: "Belum Lunas"),
                    SubmissionDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Purchase__6B0A6BDE6AC1F485", x => x.PurchaseID);
                    table.ForeignKey(
                        name: "FK__Purchase__Agreem__0C85DE4D",
                        column: x => x.AgreementID,
                        principalTable: "Agreement",
                        principalColumn: "AgreementID");
                    table.ForeignKey(
                        name: "FK__Purchase__Custom__0B91BA14",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                });

            migrationBuilder.CreateTable(
                name: "CustomerRating",
                columns: table => new
                {
                    RatingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    SalesPersonID = table.Column<int>(type: "int", nullable: true),
                    DealerID = table.Column<int>(type: "int", nullable: true),
                    ConsultHistoryID = table.Column<int>(type: "int", nullable: true),
                    TestDriveID = table.Column<int>(type: "int", nullable: true),
                    RatingType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RatingValue = table.Column<double>(type: "float", nullable: false),
                    Comments = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    RatingDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysutcdatetime())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__FCCDF85C2BCC045B", x => x.RatingID);
                    table.ForeignKey(
                        name: "FK__CustomerR__Consu__628FA481",
                        column: x => x.ConsultHistoryID,
                        principalTable: "ConsultHistory",
                        principalColumn: "ConsultHistoryID");
                    table.ForeignKey(
                        name: "FK__CustomerR__Custo__5FB337D6",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK__CustomerR__Deale__619B8048",
                        column: x => x.DealerID,
                        principalTable: "Dealer",
                        principalColumn: "DealerID");
                    table.ForeignKey(
                        name: "FK__CustomerR__Sales__60A75C0F",
                        column: x => x.SalesPersonID,
                        principalTable: "SalesPerson",
                        principalColumn: "SalesPersonID");
                    table.ForeignKey(
                        name: "FK__CustomerR__TestD__6383C8BA",
                        column: x => x.TestDriveID,
                        principalTable: "TestDrive",
                        principalColumn: "TestDriveID");
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    DealerID = table.Column<int>(type: "int", nullable: true),
                    SalesPersonID = table.Column<int>(type: "int", nullable: true),
                    ConsultHistoryID = table.Column<int>(type: "int", nullable: true),
                    TestDriveID = table.Column<int>(type: "int", nullable: true),
                    NotificationType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysutcdatetime())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Notifica__20CF2E32BD692188", x => x.NotificationID);
                    table.ForeignKey(
                        name: "FK__Notificat__Consu__6C190EBB",
                        column: x => x.ConsultHistoryID,
                        principalTable: "ConsultHistory",
                        principalColumn: "ConsultHistoryID");
                    table.ForeignKey(
                        name: "FK__Notificat__Custo__693CA210",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK__Notificat__Deale__6A30C649",
                        column: x => x.DealerID,
                        principalTable: "Dealer",
                        principalColumn: "DealerID");
                    table.ForeignKey(
                        name: "FK__Notificat__Sales__6B24EA82",
                        column: x => x.SalesPersonID,
                        principalTable: "SalesPerson",
                        principalColumn: "SalesPersonID");
                    table.ForeignKey(
                        name: "FK__Notificat__TestD__6D0D32F4",
                        column: x => x.TestDriveID,
                        principalTable: "TestDrive",
                        principalColumn: "TestDriveID");
                });

            migrationBuilder.CreateTable(
                name: "DocumentCreditApplication",
                columns: table => new
                {
                    DocumentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreditAppID = table.Column<int>(type: "int", nullable: false),
                    DocType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    File_Path = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Document__1ABEEF6F852BE01C", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK__DocumentC__Credi__151B244E",
                        column: x => x.CreditAppID,
                        principalTable: "CreditApplication",
                        principalColumn: "CreditAppID");
                });

            migrationBuilder.CreateTable(
                name: "PaymentHistory",
                columns: table => new
                {
                    PaymentHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseID = table.Column<int>(type: "int", nullable: false),
                    PaymentNominal = table.Column<int>(type: "int", nullable: false),
                    PaymentType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PaymentH__F3B93391D7DFE6B3", x => x.PaymentHistoryID);
                    table.ForeignKey(
                        name: "FK__PaymentHi__Purch__17F790F9",
                        column: x => x.PurchaseID,
                        principalTable: "Purchase",
                        principalColumn: "PurchaseID");
                });

            migrationBuilder.CreateTable(
                name: "SalesActivityLog",
                columns: table => new
                {
                    ActivityLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    DealerID = table.Column<int>(type: "int", nullable: false),
                    SalesPersonID = table.Column<int>(type: "int", nullable: false),
                    ActivityType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NotificationID = table.Column<int>(type: "int", nullable: true),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysutcdatetime())"),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SalesAct__19A9B78F2926657B", x => x.ActivityLogID);
                    table.ForeignKey(
                        name: "FK__SalesActi__Custo__70DDC3D8",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK__SalesActi__Deale__71D1E811",
                        column: x => x.DealerID,
                        principalTable: "Dealer",
                        principalColumn: "DealerID");
                    table.ForeignKey(
                        name: "FK__SalesActi__Notif__73BA3083",
                        column: x => x.NotificationID,
                        principalTable: "Notification",
                        principalColumn: "NotificationID");
                    table.ForeignKey(
                        name: "FK__SalesActi__Sales__72C60C4A",
                        column: x => x.SalesPersonID,
                        principalTable: "SalesPerson",
                        principalColumn: "SalesPersonID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agreement_CustomerID",
                table: "Agreement",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Agreement_DealerCarID",
                table: "Agreement",
                column: "DealerCarID");

            migrationBuilder.CreateIndex(
                name: "IX_Agreement_SalesPersonID",
                table: "Agreement",
                column: "SalesPersonID");

            migrationBuilder.CreateIndex(
                name: "UQ__Agreemen__412C029BD9091658",
                table: "Agreement",
                column: "LoiID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AgreementUnit_AgreementID",
                table: "AgreementUnit",
                column: "AgreementID");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementUnit_DealerCarUnitID",
                table: "AgreementUnit",
                column: "DealerCarUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "idx_Car_CarModel",
                table: "Car",
                column: "CarModel");

            migrationBuilder.CreateIndex(
                name: "idx_Car_CarType",
                table: "Car",
                column: "CarType");

            migrationBuilder.CreateIndex(
                name: "idx_Car_Make",
                table: "Car",
                column: "Make");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultHistory_CustomerID",
                table: "ConsultHistory",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultHistory_DealerCarUnitID",
                table: "ConsultHistory",
                column: "DealerCarUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultHistory_SalesPersonID",
                table: "ConsultHistory",
                column: "SalesPersonID");

            migrationBuilder.CreateIndex(
                name: "UQ__CreditAp__0A309D22083CEFDF",
                table: "CreditApplication",
                column: "AgreementID",
                unique: true,
                filter: "[AgreementID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "idx_Customer_Email",
                table: "Customer",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "idx_Customer_UserName",
                table: "Customer",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "UQ__Customer__A9D10534C957348F",
                table: "Customer",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_CustomerRating_ConsultHistoryID",
                table: "CustomerRating",
                column: "ConsultHistoryID");

            migrationBuilder.CreateIndex(
                name: "IDX_CustomerRating_CustomerID",
                table: "CustomerRating",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IDX_CustomerRating_RatingDate",
                table: "CustomerRating",
                column: "RatingDate");

            migrationBuilder.CreateIndex(
                name: "IDX_CustomerRating_SalesPersonID",
                table: "CustomerRating",
                column: "SalesPersonID");

            migrationBuilder.CreateIndex(
                name: "IDX_CustomerRating_TestDriveID",
                table: "CustomerRating",
                column: "TestDriveID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRating_DealerID",
                table: "CustomerRating",
                column: "DealerID");

            migrationBuilder.CreateIndex(
                name: "idx_Dealer_DealerName",
                table: "Dealer",
                column: "DealerName");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCar_CarID",
                table: "DealerCar",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCar_DealerID",
                table: "DealerCar",
                column: "DealerID");

            migrationBuilder.CreateIndex(
                name: "IDX_DealerCarUnit_DealerCarID",
                table: "DealerCarUnit",
                column: "DealerCarID");

            migrationBuilder.CreateIndex(
                name: "IDX_DealerCarUnit_Status",
                table: "DealerCarUnit",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IDX_DealerCarUnit_VIN",
                table: "DealerCarUnit",
                column: "VIN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__DealerCa__C5DF234C25296428",
                table: "DealerCarUnit",
                column: "VIN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentCreditApplication_CreditAppID",
                table: "DocumentCreditApplication",
                column: "CreditAppID");

            migrationBuilder.CreateIndex(
                name: "IX_LoiCarFromDealer_DealerCarUnitID",
                table: "LoiCarFromDealer",
                column: "DealerCarUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_ConsultHistoryID",
                table: "Notification",
                column: "ConsultHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_CustomerID",
                table: "Notification",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_DealerID",
                table: "Notification",
                column: "DealerID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_SalesPersonID",
                table: "Notification",
                column: "SalesPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_TestDriveID",
                table: "Notification",
                column: "TestDriveID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentHistory_PurchaseID",
                table: "PaymentHistory",
                column: "PurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CustomerID",
                table: "Purchase",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "UQ__Purchase__0A309D2284C52C28",
                table: "Purchase",
                column: "AgreementID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesActivityLog_CustomerID",
                table: "SalesActivityLog",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesActivityLog_DealerID",
                table: "SalesActivityLog",
                column: "DealerID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesActivityLog_NotificationID",
                table: "SalesActivityLog",
                column: "NotificationID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesActivityLog_SalesPersonID",
                table: "SalesActivityLog",
                column: "SalesPersonID");

            migrationBuilder.CreateIndex(
                name: "IDX_SalesPerson_DealerID",
                table: "SalesPerson",
                column: "DealerID");

            migrationBuilder.CreateIndex(
                name: "IDX_SalesPerson_FullName",
                table: "SalesPerson",
                column: "FullName");

            migrationBuilder.CreateIndex(
                name: "idx_SalesPerson_IsActive_True",
                table: "SalesPerson",
                column: "IsActive",
                filter: "([IsActive]=(1))");

            migrationBuilder.CreateIndex(
                name: "IDX_SalesPerson_PhoneNumber",
                table: "SalesPerson",
                column: "PhoneNumber");

            migrationBuilder.CreateIndex(
                name: "ux_SalesPerson_Email_NotNull",
                table: "SalesPerson",
                column: "Email",
                unique: true,
                filter: "([Email] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "idx_SalesPersonPerformance_SalesPerson_Metric",
                table: "SalesPersonPerformance",
                columns: new[] { "SalesPersonID", "MetricType", "MetricDate" });

            migrationBuilder.CreateIndex(
                name: "UQ_SalesPersonPerformance_Metric",
                table: "SalesPersonPerformance",
                columns: new[] { "SalesPersonID", "MetricType", "MetricDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_TestDrive_AppointmentDate",
                table: "TestDrive",
                column: "AppointmentDate");

            migrationBuilder.CreateIndex(
                name: "IDX_TestDrive_CustomerID",
                table: "TestDrive",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IDX_TestDrive_DealerCarUnitID",
                table: "TestDrive",
                column: "DealerCarUnitID");

            migrationBuilder.CreateIndex(
                name: "IDX_TestDrive_SalesPersonID",
                table: "TestDrive",
                column: "SalesPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyClaim_CustomerID",
                table: "WarrantyClaim",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyClaim_WarrantyID",
                table: "WarrantyClaim",
                column: "WarrantyID");

            migrationBuilder.CreateIndex(
                name: "UQ__Warranty__7DD0B56733E60679",
                table: "WarrantyRegistration",
                column: "DealerCarID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreementUnit");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CustomerRating");

            migrationBuilder.DropTable(
                name: "DocumentCreditApplication");

            migrationBuilder.DropTable(
                name: "LoiCarFromDealer");

            migrationBuilder.DropTable(
                name: "PaymentHistory");

            migrationBuilder.DropTable(
                name: "SalesActivityLog");

            migrationBuilder.DropTable(
                name: "SalesPersonPerformance");

            migrationBuilder.DropTable(
                name: "WarrantyClaim");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CreditApplication");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "WarrantyRegistration");

            migrationBuilder.DropTable(
                name: "Agreement");

            migrationBuilder.DropTable(
                name: "ConsultHistory");

            migrationBuilder.DropTable(
                name: "TestDrive");

            migrationBuilder.DropTable(
                name: "LetterOfIntent");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "DealerCarUnit");

            migrationBuilder.DropTable(
                name: "SalesPerson");

            migrationBuilder.DropTable(
                name: "DealerCar");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Dealer");
        }
    }
}
