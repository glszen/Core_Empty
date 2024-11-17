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

//Controller: C# (Back-end tarafýnýn yazýldýðý kýsýmdýr.)

//IActionResult: Çeþitli sonuç türlerini döndürebilmeyi saðlar, bir kaynak üzerinde gerçekleþtirilebilecek eylemleri saðlar.

//View: Bu Action'a karþýlýk gelen kullanýcý arayüzüdür.

//Razor: Razor, dinamik sayfalar oluþturmaya yarayan bir programlama sözdizimidir. 

//RazorView: Razor Sözdizimi MVC uygulamalarýmýz içerisinde kolay bir þekilde HTML üretmemize yardýmcý olur.

//wwwroot: Css, Javascript dosyalarý, resimler gibi, browser'ýn ulaþmasý gerken tüm dosyalarýn koyulduðu yer.

//builder.Build(): Uygulama yapýlandýrýldýktan sonra, yapýlandýrýlmýþ uygulama(builder) oluþturulmasýný saðlar.

//app.Run(): Uygulamayý baþlatýr.