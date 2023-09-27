using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pruebaEntity.Migrations
{
    public partial class AddAuthentication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aspnetroles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aspnetroles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<short>(type: "smallint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DownloadUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "input",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<short>(type: "smallint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    SidewalkId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductiveSystemId = table.Column<int>(type: "int", nullable: true),
                    CropYield = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CropProductionCosts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitialSowingDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalSowingDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaCrop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinagroCcredit = table.Column<short>(type: "smallint", nullable: true),
                    PlantsByHectare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientSize = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_input", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "logs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Level = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _ts = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "modeloutputs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descriptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MensajeError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MostrarEnPantalla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosicionValor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modeloutputs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "municipios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_departamento_id = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "preguntas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    texto_pregunta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_preguntas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipo_respuestas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_respuestas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tiposCultivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    habilitado = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiposCultivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userapp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: true),
                    EmailConfirmed = table.Column<short>(type: "smallint", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<short>(type: "smallint", nullable: true),
                    TwoFactorEnabled = table.Column<short>(type: "smallint", nullable: true),
                    LockoutEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<short>(type: "smallint", nullable: true),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userapp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "veredas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_muncipio_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    logitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitud = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veredas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<short>(type: "smallint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionBook = table.Column<int>(type: "int", nullable: true),
                    PositionValue = table.Column<int>(type: "int", nullable: true),
                    Visibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sheets", x => x.Id);
                    table.ForeignKey(
                        name: "FK__sheets__BookId__619B8048",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "quote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<short>(type: "smallint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InputId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quote", x => x.Id);
                    table.ForeignKey(
                        name: "FK__quote__InputId__5DCAEF64",
                        column: x => x.InputId,
                        principalTable: "input",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "encuestas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    id_pregunta = table.Column<int>(type: "int", nullable: true),
                    id_sistema_productivo = table.Column<int>(type: "int", nullable: true),
                    id_tipo_respuesta = table.Column<int>(type: "int", nullable: true),
                    respuesta_manual = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_encuestas", x => x.Id);
                    table.ForeignKey(
                        name: "FK__encuestas__id_pr__6754599E",
                        column: x => x.id_pregunta,
                        principalTable: "preguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__encuestas__id_ti__68487DD7",
                        column: x => x.id_tipo_respuesta,
                        principalTable: "tipo_respuestas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "respuestas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    tipo_respuesta_id = table.Column<int>(type: "int", nullable: true),
                    respuesta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_respuestas", x => x.Id);
                    table.ForeignKey(
                        name: "FK__respuesta__tipo___5EBF139D",
                        column: x => x.tipo_respuesta_id,
                        principalTable: "tipo_respuestas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "subtipos_cultivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_tipo_cultivo = table.Column<int>(type: "int", nullable: true),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    habilitado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subtipos_cultivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK__subtipos___id_ti__628FA481",
                        column: x => x.id_tipo_cultivo,
                        principalTable: "tiposCultivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "inssuingquotations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<short>(type: "smallint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserAppId = table.Column<int>(type: "int", nullable: true),
                    InputId = table.Column<int>(type: "int", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    SesionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inssuingquotations", x => x.Id);
                    table.ForeignKey(
                        name: "FK__inssuingq__BookI__5AEE82B9",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__inssuingq__Input__59FA5E80",
                        column: x => x.InputId,
                        principalTable: "input",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__inssuingq__UserA__5812160E",
                        column: x => x.UserAppId,
                        principalTable: "userapp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "roleApp",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__roleApp__AF2760AD7FAE5194", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK__roleApp__UserId__5FB337D6",
                        column: x => x.UserId,
                        principalTable: "userapp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "userappbooks",
                columns: table => new
                {
                    UserAppId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__userappb__298AF2937FD84470", x => new { x.BookId, x.UserAppId });
                    table.ForeignKey(
                        name: "FK__userappbo__BookI__66603565",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__userappbo__UserA__656C112C",
                        column: x => x.UserAppId,
                        principalTable: "userapp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_encuestas_id_pregunta",
                table: "encuestas",
                column: "id_pregunta");

            migrationBuilder.CreateIndex(
                name: "IX_encuestas_id_tipo_respuesta",
                table: "encuestas",
                column: "id_tipo_respuesta");

            migrationBuilder.CreateIndex(
                name: "IX_inssuingquotations_BookId",
                table: "inssuingquotations",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_inssuingquotations_InputId",
                table: "inssuingquotations",
                column: "InputId");

            migrationBuilder.CreateIndex(
                name: "IX_inssuingquotations_UserAppId",
                table: "inssuingquotations",
                column: "UserAppId");

            migrationBuilder.CreateIndex(
                name: "IX_quote_InputId",
                table: "quote",
                column: "InputId");

            migrationBuilder.CreateIndex(
                name: "IX_respuestas_tipo_respuesta_id",
                table: "respuestas",
                column: "tipo_respuesta_id");

            migrationBuilder.CreateIndex(
                name: "IX_sheets_BookId",
                table: "sheets",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_subtipos_cultivos_id_tipo_cultivo",
                table: "subtipos_cultivos",
                column: "id_tipo_cultivo");

            migrationBuilder.CreateIndex(
                name: "IX_userappbooks_UserAppId",
                table: "userappbooks",
                column: "UserAppId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aspnetroles");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "encuestas");

            migrationBuilder.DropTable(
                name: "inssuingquotations");

            migrationBuilder.DropTable(
                name: "logs");

            migrationBuilder.DropTable(
                name: "modeloutputs");

            migrationBuilder.DropTable(
                name: "municipios");

            migrationBuilder.DropTable(
                name: "quote");

            migrationBuilder.DropTable(
                name: "respuestas");

            migrationBuilder.DropTable(
                name: "roleApp");

            migrationBuilder.DropTable(
                name: "sheets");

            migrationBuilder.DropTable(
                name: "subtipos_cultivos");

            migrationBuilder.DropTable(
                name: "userappbooks");

            migrationBuilder.DropTable(
                name: "veredas");

            migrationBuilder.DropTable(
                name: "preguntas");

            migrationBuilder.DropTable(
                name: "input");

            migrationBuilder.DropTable(
                name: "tipo_respuestas");

            migrationBuilder.DropTable(
                name: "tiposCultivos");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "userapp");
        }
    }
}
