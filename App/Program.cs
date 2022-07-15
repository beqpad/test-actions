using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();



// unsafe
// {
//     var a = new Struct1();
//     var p = (byte*)&a;

//     *(p + 2) = (byte)0x00;
// }

[StructLayout(LayoutKind.Sequential)]
public struct Struct1
{
    public Struct1() { }

    public byte A = 0x10;
}