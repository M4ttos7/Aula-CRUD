namespace TesteC.Models
{
    public class Repository : IRepository
    {
        private Dictionary<int, Reserva> items;

        public Repository()
        {
            items = new Dictionary<int, Reserva>();

            new List<Reserva> {
                new Reserva {Reservald=1, Nome= "Macoratti", InicioLocacao = "São Paulo", FimLocacao="Lins" },
                new Reserva {Reservald=2, Nome = "Paulo", InicioLocacao = "Campinas", FimLocacao ="São Paulo" },
                new Reserva {Reservald=3, Nome= "Maria", InicioLocacao= "Jundiai", FimLocacao="Campinas" }
                }.ForEach(r => AddReserva(r));
        }

        public Reserva this[int id] => items.ContainsKey(id) ? items[id] : null;

        public IEnumerable<Reserva> Reservas => items.Values;

        public Reserva AddReserva(Reserva reserva)
        {
            if (reserva.Reservald == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                reserva.Reservald = key;
            }
            items[reserva.Reservald] = reserva;
            return reserva;
        }
        public void DeleteReserva(int id)
        {
            items.Remove(id);
        }

        public Reserva UpdateReserva(Reserva reserva)
        {
            AddReserva(reserva);
            return reserva;
        }
    }
}