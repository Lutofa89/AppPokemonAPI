namespace AppPokemonAPI
{
    public class DamageRelations
    {
        public List<DoubleDamageFrom> double_damage_from { get; set; }
        public List<DoubleDamageTo> double_damage_to { get; set; }
        public List<HalfDamageFrom> half_damage_from { get; set; }
        public List<HalfDamageTo> half_damage_to { get; set; }
        public List<NoDamageFrom> no_damage_from { get; set; }
        public List<object> no_damage_to { get; set; }
    }
}
