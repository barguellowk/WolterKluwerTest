using WolterKluwerTest.ServiceContract;
using WolterKluwerTest.ServicesImplements;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAppService, AppService>();
builder.Services.AddScoped<IIdentityService, IdentityService>();
builder.Services.AddScoped<ILicensedService, LicensedService>();
builder.Services.AddScoped<IMemberService, MemberService>();
builder.Services.AddScoped<IOrganizationService, OrganizationService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpeificOrigin",
    builder =>
    {
        builder.WithOrigins("*").WithHeaders("*").WithMethods("*");
    });
}

);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowSpeificOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();
