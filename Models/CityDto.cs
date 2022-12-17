﻿namespace NetCore6WebApi.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public IEnumerable<CityStreetDto> Streets { get; set; } = new List<CityStreetDto>();
    }
}
