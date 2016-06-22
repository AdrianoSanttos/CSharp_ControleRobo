# CSharp_ControleRobo
Teste executado para uma entrevista de emprego:

Escopo
Aplicacao para controlar remotamente um robo prospector de petroleo. O
robo funciona da seguinte maneira:
- Em um dado momento, o robo se encontra em 1 de 4 estados possiveis:
o Pronto: O robo pode receber uma nova tarefa e realiza-la
imediatamente.
o Ocupado: O robo se encontra executando uma determinada tarefa e não
pode receber novas tarefas.
o Recuperando: O robo não esta executando nenhuma tarefa, mas ja pode
receber a proxima tarefa que ira executar apos o período de recuperacao.
o Cheio: O compartimento de petroleo do robo esta cheio e o mesmo nao
esta mais apto para servico. Isto ocorre apos 5 extracoes bem sucedidas
de petroleo.
- O robo pode receber diversas tarefas, em especial para este teste, as
seguintes tarefas sao necessarias:
o (A)ndar: O robo anda por 15 segundos para uma localidade não
explorada.
o (P)rocurar: O robo procura petroleo por 25 segundos no local atual. A
chance de encontrar petroleo e de 50% apos os 25 segundos.
o Extrair: O robo extrai petróleo da área atual por 30 segundos. Para
efeito deste exemplo, uma extração sempre é bem sucedida pois so deve
ser ordenada apos um sucesso em uma acao de “procurar”.
- Por limitacoes de projeto, o robo nao e uma entidade inteligente capaz
de tomar decisoes por si so e, todas estas devem vir de um ou mais
centros de comando. O software do centro de comando pode receber como
input um padrao de buscas para enviar para o robo executar. Exemplo:
o A A P P A A A P - O software enviará para o robô as ordens de “andar”,
“andar”, “procurar”, “procurar”, “andar”, “andar”, “andar” e “procurar”
- O software do centro de comando deve ordenar que o robo realize
extracao de petroleo sempre que uma operacao de buscar o encontrar.
- A missao do robo deve ser considerada um sucesso se, apos executar o
script
de buscas, o mesmo estiver em um estado “Cheio”.

Scope
Application to remotely control a prospector robo oil. The robot works
as follows:
- At one point, the robot is in one of four possible states:
Ready: The robot can receive a new task and performs it immediately.
Busy: The robot is performing a certain task and can not receive new
jobs.
Recovering: The robot is not executing any task, but can already receive
the next task that will run after the recovery period.
the Full: The oil compartment robo is full and it is not this more fit
for service. This occurs after 5 successful extractions of oil.
- The robot can receive various tasks, especially for this test, the
following tasks are necessary:
(A) ndar: The robot walks for 15 seconds to a location not exploited.
the (P) rocurar: The robo demand oil for 25 seconds at the current
location. The chance of finding oil and 50% after 25 seconds.
the Extract: The robot extracts oil from the current area for 30
seconds. For purposes of this example, an extraction is always
successful because only be ordered after a success in an action of
"search".
- By design limitations, the robot and not an intelligent entity capable
of taking decisions by itself and all these must come from one or more
control centers. The Command Center software can receive as input a
search pattern to send to the robo run. Example:
o P P A A P - The software will send the commands to the robot to
"walk", "walk", "search", "search", "walk", "walk", "walking" and
"search"
- The command center software should order the robot to perform
extraction of oil whenever an operation to search to find it.
- The mission of the robot should be considered a success if, after
running the script
search, it is in a "Full" state.
