using ApiFolha.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

//Cadastro de novos funcionarios OK
app.MapPost("/api/funcionario/cadastrar", async ([FromBody] Funcionario funcionario, [FromServices] AppDbContext contextFuncionarios) =>
{

    contextFuncionarios.Funcionarios.Add(funcionario);
    await contextFuncionarios.SaveChangesAsync();

    return Results.Created("", funcionario);
});

//Listar todos os funcionários OK
app.MapGet("/api/funcionario/listar", async ([FromServices] AppDbContext contextFuncionarios) =>
{
    var funcionarios = await contextFuncionarios.Funcionarios.ToListAsync();
    if (funcionarios.Any())
    {
        return Results.Ok(funcionarios);
    }
    return Results.NotFound("Nenhum funcionário registrado");
});

//Cadastro de folha
app.MapPost("/api/folha/cadastrar", async ([FromBody] Folha folha, [FromServices] AppDbContext contextFolha) =>
{
    contextFolha.Folhas.Add(folha);
    await contextFolha.SaveChangesAsync();

    return Results.Created("", folha);
});


/*
app.MapGet("/api/produto/{id}", async ([FromRoute] string id, [FromServices] AppDataContext context) =>
{
    var produto = await context.Produtos.FindAsync(id);

    if (produto is null)
    {
        return Results.NotFound("Produto não encontrado.");
    }

    return Results.Ok(produto);
});*/


app.Run();
