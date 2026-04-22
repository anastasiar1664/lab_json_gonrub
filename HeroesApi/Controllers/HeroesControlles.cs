using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using HeroesApi.Models;
using HeroesApi.Data;

namespace HeroesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HeroesController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Hero>> GetAll()
    {
        return Ok(HeroesStore.Heroes);
    }

    [HttpGet("{id}")]
    public ActionResult<Hero> GetById(int id)
    {
        var hero = HeroesStore.Heroes.FirstOrDefault(h => h.Id == id);
        if (hero is null)
        {
            return NotFound(new { message = $"Герой с id={id} не найден" });
        }

        return Ok(hero);
    }
    [HttpGet("demo")]
    public ActionResult GetDemo()
    {
        var hero = HeroesStore.Heroes.First();
        var defaultOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        var ourOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };
        return Ok(new
        {
            withDefaultSettings = JsonSerializer.Deserialize<object>(JsonSerializer.Serialize(hero, defaultOptions), defaultOptions),
            withOurSettings = JsonSerializer.Deserialize<object>(JsonSerializer.Serialize(hero, ourOptions), ourOptions),
            note = "Сравните имена полей и значение universe в двух вариантах"
        });
    }
    [HttpGet("serialize")]
    public ActionResult GetSerialize()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };
        var hero = new Hero
        {
            Id = 999,
            Name = "ИванЗоло2004",
            RealName = "Иван Золочевский",
            Universe = Universe.IvanZolo2004,
            PowerLevel = 999,
            Powers = new() { "лайкер", "стример", "тиктокер", "певец", "в будущем актер" },
            Weapon = new() { Name = "Баобаб", IsRanged = true },
            InternalNotes = "скрытый талант скрывай дальше пж"
        };
        string serialized = JsonSerializer.Serialize(hero, options);
        var deserialized = JsonSerializer.Deserialize<Hero>(serialized, options);
        return Ok(new
        {
            serializedJson = serialized,
            deserializedObject = deserialized,
            internalNotesAfterDeserialize = deserialized?.InternalNotes ?? "null - поле было проигнорировано"
        });
    }
}