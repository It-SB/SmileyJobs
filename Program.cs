using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Smile.Areas.Identity.Data;
using Smile.Data;
using Smile.Models.Contact;
using Smile.Models.Jobs;
using Microsoft.Extensions.DependencyInjection;
using Smile.Models.Applications;
using Smile.Models.Admins;
using SmileyJobs.Controllers;
using Smile.Models.JobListing;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationSContext") ?? throw new InvalidOperationException("Connection string 'ApplicationSContext' not found.")));
var connectionString = builder.Configuration.GetConnectionString("SmileContextConnection") ?? throw new InvalidOperationException("Connection string 'SmileContextConnection' not found.");


builder.Services.AddDbContext<SmileContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<AdminsContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<JobListingContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<JobsContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<ContactContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<ApplicationsContext>(options => options.UseSqlServer(connectionString));



builder.Services.AddDefaultIdentity<SmileUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<SmileContext>();

//builder.Services.AddDefaultIdentity<Job>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<SmileContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
