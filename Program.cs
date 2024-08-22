var builder = WebApplication.CreateBuilder(args);
//Add server
builder.Services.AddDbContext<AgendaContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

// Adicionar serviços para controladores
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapear os controladores
app.MapControllers();

app.Run();