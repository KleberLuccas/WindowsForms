using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public Fichario(string Diretorio)
        {
            status = true;
            try
            {
                if (!Directory.Exists(Diretorio))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                mensagem = "Conexão com o fichário criada com sucesso";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o fichário com erro" + ex.Message;
            } 
        }
        
        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    mensagem = "Inclusão não permitida porque o identificador já existe" + Id;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    mensagem = "Inclusão efetuada com sucesso, identificador:" + Id;
                    status = true;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o fichário com erro" + ex.Message;
            }
        }

        public string Buscar(string Id)
        {
            status = true;
            try
            {
                if (!File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    mensagem = "Identificador não existente" + Id;
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + Id + ".json");
                    mensagem = "Inclusão efetuada com sucesso, identificador:" + Id;
                    status = true;
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador." + ex.Message;
            }

            return ""; 
        }

        public void Apagar(string Id)
        {
            status = true;
            try
            {
                if (!File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    mensagem = "Identificador não existente" + Id;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");
                    mensagem = "Exclusão efetuada com sucesso, identificador:" + Id;
                    status = true;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador." + ex.Message;
            }
        }
    }
}
