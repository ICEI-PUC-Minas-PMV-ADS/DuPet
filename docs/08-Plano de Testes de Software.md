# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

|**Atividade(tela)**|**Ação**|**Resultado Esperado**|
|-------------------|--------|----------------------|
|HomePage|CT 1: Clicar no botão “Home”|CT 1: Ação concluida.|
||CT 1.1: Clicar no botão "Sobre"| CT 1.1 : Ação concluida. |
||CT 1.2: Clicar no Botão " Contato"| CT 1.2 : Ação concluida. |
||CT 1.3: Clicar no Botão " Cadastro " |CT 1.3: Ação concluida.|
||CT 1.4: Clicar no Botão " Entrar "|CT 1.4 : Ação concluida|
|Tela Login|CT 2: Ao entrar no menu Login, o usuário vai se deparar com as opções ( "Email" e "Senha" )|CT 2: Ao preencher o campo email e senha deve-se fazer o login corretamente.  |
||CT 2.1: Ao entrar no  CT 1.3, o usuário vai se deparar com as opções ( "Email" e "Senha" )|CT 2.1: Ao preencher o campo email e senha com dados incorretos deve exibir a mensagem " Verifique email e senha "   |
| |CT 2.2: Ao clicar no campo " esqueceu a senha?"|CT 2.2: Deve-se abrir outra tela com os dados para preenchimento da recuperação de tela.|
|Cadastro |CT 3: vai ser usado o CT 1.3 |CT 3: Verificar todos os campos se estão aceitando todos os dados corretamente |
||CT 3: vai ser usado o CT 1.3 |CT 3: Verificar todos os campos se o campo " Nome Completo " esta Correto. |
||CT 3.1: vai ser usado o CT 1.3 |CT 3.1: Verificar todos os campos se o campo " Email " esta Correto. |
||CT 3.2: vai ser usado o CT 1.3 |CT 3.2: Verificar todos os campos se o campo " Senha e Confirmar Senha  " esta Correto e aceitando as marcara de privacidade. |
||CT 3.3: vai ser usado o CT 1.3 |CT 3.3: Verificar todos os campos se o campo " Celular " esta Correto. e aceitando a marcara corretamente dos 9 digitos |
||CT 3.4: vai ser usado o CT 1.3 |CT 3.4: Verificar todos os campos se o campo " Localização " esta Correto. |
||CT 3.5: vai ser usado o CT 1.3 |CT 3.5: Verificar todos os campos se o campo " Nome Completo " esta Correto. |
||CT 3.6: vai ser usado o CT 1.3 |CT 3.6: Ao preencher todos os campos ao clicar no " concluir Cadastro " deve-se ir para a Pagina inicial do projeto |
||CT 3.7: vai ser usado o CT 1.3 |CT 3.7: Verificar Quando digitar um campo incorreto o sistema deve exibir a mensagem " Dados incorretos e marcar qual campo esta incorreto. |
|Pagina Inicial |CT 4: Ao clicar no campo "Adiconar um Pet" | CT 4 : Vai ser direcionado vai ser direcionado para a tela " Adicionando seu Pet"  |
|Adicionando seu Pet |CT 5: Verificar se todos os campos Estão aceitando os campos corretamente | CT 5: Verificar se o campo " qual a especie do seu pet? " esta aceitando os dados corretamente. |
||CT 5.1: Verificar se todos os campos Estão aceitando os campos corretamente | CT 5.1: Verificar se o campo " Qual e o nome ? " esta aceitando os dados corretamente. |
||CT 5.2: Verificar se todos os campos Estão aceitando os campos corretamente | CT 5.2: Verificar se o campo " Qual e o sexo? " esta aceitando os dados corretamente. |
||CT 5.3: Verificar se todos os campos Estão aceitando os campos corretamente | CT 5.3: Verificar se o campo " Qual e a raça " esta aceitando os dados corretamente. |
||CT 5.4: Verificar se todos os campos Estão aceitando os campos corretamente | CT 5.4: Verificar se o campo "Foto" esta aceitando os dados corretamente. |
||CT 5.6: Ao digitar um dado errado | CT 5.6: Verificar Quando digitar um campo incorreto o sistema deve exibir a mensagem " Dados incorretos "  e marcar qual campo esta incorreto. |
|Pagina Inicial |CT 6: No campo Meus Pets  | CT 6: Deve aparecer todos os pets do Usuario cadastrado. |
|Pagina Inicial |CT 7: Escolher um Pet   | CT 7: Ao clicar no pet do Usuario da sua esoclha deve abrir uma nova de registro do cadastro do pet . |
|Perfil do Pet |CT 8: Perfil do Pet  | CT 8: Verificar se o campo " Nome " esta aceitando os dados corretamente. |
||CT 8.1: Perfil do Pet  | CT 8: Verificar se o campo " Especie " esta aceitando os dados corretamente. |
||CT 8.2: Perfil do Pet  | CT 8: Verificar se o campo " Sexo " esta aceitando os dados corretamente. |
||CT 8.3: Perfil do Pet  | CT 8: Verificar se o campo " Raça " esta aceitando os dados corretamente. |
||CT 8.4: Perfil do Pet  | CT 8: Verificar se o campo " Data de Nascimento " esta aceitando os dados corretamente. |
||CT 8.5: Perfil do Pet  | CT 8: Verificar se o campo " Peso " esta aceitando os dados corretamente. |
||CT 8.6: Ao digitar um dado errado  | CT 8: Verificar Quando digitar um campo incorreto. o sistema deve exibir a mensagem " Dados incorretos "  e marcar qual campo esta incorreto. |






Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Enumere quais cenários de testes foram selecionados para teste. Neste tópico o grupo deve detalhar quais funcionalidades avaliadas, o grupo de usuários que foi escolhido para participar do teste e as ferramentas utilizadas.
 
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
