﻿using System.Text.Json.Serialization;

namespace MauiApp1.Model;

public class User
{
    public string Name { get; set; }
    public string Location {  get; set; }
    public string Details { get; set; }
    public string Image {  get; set; }
    public int Population { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
