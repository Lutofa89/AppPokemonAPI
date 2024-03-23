using System.Xml.Linq;

namespace AppPokemonAPI
{
    

        public class Root
        {
            public DamageRelations damage_relations { get; set; }
            public List<GameIndex> game_indices { get; set; }
            public Generation generation { get; set; }
            public int id { get; set; }
            public MoveDamageClass move_damage_class { get; set; }
            public List<Move> moves { get; set; }
            public string name { get; set; }
            public List<Name> names { get; set; }
            public List<object> past_damage_relations { get; set; }
            public List<Pokemon> pokemon { get; set; }
        }

    }

