using System;

namespace domain.nvc
{
    public class VehicleType
    {
        public int Id { get; set; }
        public VehicleGroup VehicleGroup { get; set; }
        public string Naam { get; set; }
        public string Code { get; set; }
        public VoertuigEigenschappen VoertuigEigenschappen { get; set; }
        public int AantalAssen { get; set; }
        public int AantalAchterAssen { get; set; }
        public int PictureIndex { get; set; }
    }

    [Flags]
    public enum VoertuigEigenschappen
    {
        IsVoorVoertuig = 1,
        HeeftVoorAssen = 2,
        HeeftVoorzijdeHartKoppel = 4,
        HeeftHartKoppelAchterzijde = 8,
        HeeftKoppeldruks = 16,
        HeeftNek = 32,
        HeeftKuil = 64,
        HeeftVoorAssStel = 128,
        HeeftHartKoppelVooras = 256,
        HeeftVoorzijdeBak = 512,
        HeeftBak = 1024
    }
}