﻿namespace Application.Features.Brands.Queries.GetList;

public class GetListBrandListItemDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdateddDate { get; set; }
}