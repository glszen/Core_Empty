var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

await using var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapDefaultControllerRoute();
await app.RunAsync();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//Controller: C# (Back-end taraf�n�n yaz�ld��� k�s�md�r.)

//IActionResult: �e�itli sonu� t�rlerini d�nd�rebilmeyi sa�lar, bir kaynak �zerinde ger�ekle�tirilebilecek eylemleri sa�lar.

//View: Bu Action'a kar��l�k gelen kullan�c� aray�z�d�r.

//Razor: Razor, dinamik sayfalar olu�turmaya yarayan bir programlama s�zdizimidir. 

//RazorView: Razor S�zdizimi MVC uygulamalar�m�z i�erisinde kolay bir �ekilde HTML �retmemize yard�mc� olur.

//wwwroot: Css, Javascript dosyalar�, resimler gibi, browser'�n ula�mas� gerken t�m dosyalar�n koyuldu�u yer.

//builder.Build(): Uygulama yap�land�r�ld�ktan sonra, yap�land�r�lm�� uygulama(builder) olu�turulmas�n� sa�lar.

//app.Run(): Uygulamay� ba�lat�r.