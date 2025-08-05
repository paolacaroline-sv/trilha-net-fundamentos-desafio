namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Menu CADASTRAR VEÍCULO selecionado.\n");

            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.Write("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"\nO veículo {placa} foi adicionado com sucesso.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Menu REMOVER VEÍCULO selecionado.\n");
            Console.Write("Digite a placa do veículo para remover: ");            
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                Console.Write("Quantas horas o veículo permaneceu estacionado: ");                
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);
                Console.WriteLine($"\nO veículo {placa} foi removido e o valor total foi de: {valorTotal:C}");
            }
            else
            {
                Console.WriteLine($"\nVeículo {placa} não encontrado. Verifique se digitado corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Menu LISTAR VEÍCULOS selecionado.\n");
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string car in veiculos)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
