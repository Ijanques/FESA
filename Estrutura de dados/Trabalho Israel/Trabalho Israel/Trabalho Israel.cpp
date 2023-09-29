// Trabalho Israel.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
#include <random>
#include <vector>
#include <thread>
#include <chrono>
#include <mutex>
#include <list>
using namespace std;
const int MAX_SIZE = 10000;

class GeradorAleat {
public:
    static int GetAleat(int max) {
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dist(1, max);

        return dist(gen);
    }
};

class Node {
public:
    int data;
    Node* prev;
    Node* next;

    Node(int value) : data(value), prev(nullptr), next(nullptr) {}
};


class MinhaListaDuplamenteEncadeada {
private:
    Node* head;
    Node* tail;


public:

    MinhaListaDuplamenteEncadeada() : head(nullptr), tail(nullptr) {}


    void inserirElemento(int elemento) {
        Node* newNode = new Node(elemento);
        if (!head) {
            head = newNode;
            tail = newNode;
        }
        else {
            tail->next = newNode;
            newNode->prev = tail;
            tail = newNode;
        }
    }

    int acessarElemento(int indice) {
        Node* current = head;
        int currentIndex = 0;

        while (current) {
            if (currentIndex == indice) {
                return current->data;
            }
            current = current->next;
            currentIndex++;
        }

        std::cout << "Indice invalido.\n";
        return -1; // Valor inválido para indicar erro
    }

    void removerElemento(int indice) {
        Node* current = head;
        int currentIndex = 0;

        while (current) {
            if (currentIndex == indice) {
                if (current->prev) {
                    current->prev->next = current->next;
                }
                else {
                    head = current->next;
                }
                if (current->next) {
                    current->next->prev = current->prev;
                }
                else {
                    tail = current->prev;
                }
                delete current;
                return;
            }
            current = current->next;
            currentIndex++;
        }

        std::cout << "Indice invalido.\n";
    }

    void mostrarLista() {
        Node* current = head;
        while (current) {
            std::cout << current->data << " ";
            current = current->next;
        }
        std::cout << std::endl;
    }

    int size(){
        Node* current = head;
        int count = 0;
        while (current) {
            count++;
            current = current->next;
        }
        return count;
    }

};

class ProcessadorPag{
public:
    static void ProcessarPag(int pagamento) {
        cout << "Processando pagamento " << pagamento << endl;
            SimularProcesso();
    }
private:
    static void SimularProcesso(){ 
        int pausa = GeradorAleat::GetAleat(10);
        this_thread::sleep_for(chrono::microseconds(pausa));
    }
};



void serverThread(int id, MinhaListaDuplamenteEncadeada& listaDePagamentos, mutex& mtx) {
    while (true) {
        int Pagamento;

        {
            unique_lock<mutex> lock(mtx);
            if (listaDePagamentos.size() == 0)
                break;
            Pagamento = listaDePagamentos.acessarElemento(0);
            listaDePagamentos.removerElemento(0);
        }
        ProcessadorPag::ProcessarPag(Pagamento);
    }
}

int main()
{   
    MinhaListaDuplamenteEncadeada DupLista1000;
    MinhaListaDuplamenteEncadeada DupLista5000;
    MinhaListaDuplamenteEncadeada DupLista10000;
    for (int i = 0; i < 10000; ++i) {
        int pagamento = GeradorAleat::GetAleat(MAX_SIZE); // Gere pagamentos aleatórios
        DupLista1000.inserirElemento(pagamento); // Insira o pagamento na lista apropriada
    }
    for (int i = 0; i < 5000; ++i) {
        int pagamento = GeradorAleat::GetAleat(MAX_SIZE); // Gere pagamentos aleatórios
        DupLista5000.inserirElemento(pagamento); // Insira o pagamento na lista apropriada
    }
    for (int i = 0; i < MAX_SIZE; ++i) {
        int pagamento = GeradorAleat::GetAleat(MAX_SIZE); // Gere pagamentos aleatórios
        DupLista10000.inserirElemento(pagamento); // Insira o pagamento na lista apropriada
    }
    int numServers = 2;
    mutex mtx;
    vector<thread> serverThreads;

    for (int i = 0; i < numServers; ++i) {
        serverThreads.emplace_back(serverThread, i, ref(DupLista10000), ref(mtx));
    }


    for (auto& thread : serverThreads) {
        thread.join();
    }
   
    return 0;
}
