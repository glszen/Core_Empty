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

//Controller: C# (Back-end tarafının yazıldığı kısımdır.)

//IActionResult: Çeşitli sonuç türlerini döndürebilmeyi sağlar, bir kaynak üzerinde gerçekleştirilebilecek eylemleri sağlar.

//View: Bu Action'a karşılık gelen kullanıcı arayüzüdür.

//Razor: Razor, dinamik sayfalar oluşturmaya yarayan bir programlama sözdizimidir. 

//RazorView: Razor Sözdizimi MVC uygulamalarımız içerisinde kolay bir şekilde HTML üretmemize yardımcı olur.

//wwwroot: Css, Javascript dosyaları, resimler gibi, browser'ın ulaşması gerken tüm dosyaların koyulduğu yer.

//builder.Build(): Uygulama yapılandırıldıktan sonra, yapılandırılmış uygulama(builder) oluşturulmasını sağlar.

//app.Run(): Uygulamayı başlatır.