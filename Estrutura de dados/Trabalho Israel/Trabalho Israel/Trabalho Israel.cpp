// Trabalho Israel.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
#include <random>
#include <vector>
using namespace std;
const int MAX_SIZE = 10000;

int GeradorAleat() {
    random_device rd;
    mt19937 gen(rd());
    uniform_int_distribution<> dist(1, 10000);

    return dist(gen);
}
class MinhaLista {
private:
    int lista[MAX_SIZE];
    int tamanho;

public:
    MinhaLista() {
        tamanho = 0;
    }

    void inserirElemento(int elemento) {
        if (tamanho < MAX_SIZE) {
            lista[tamanho++] = elemento;
        }
        else {
            cout << "Lista cheia. Nao e possivel inserir mais elementos.\n";
        }
    }

    int acessarElemento(int indice) {
        if (indice >= 0 && indice < tamanho) {
            return lista[indice];
        }
        else {
            std::cout << "Indice invalido.\n";
            return -1; // Valor inválido para indicar erro
        }
    }

    void removerElemento(int indice) {
        if (indice >= 0 && indice < tamanho) {
            for (int i = indice; i < tamanho - 1; ++i) {
                lista[i] = lista[i + 1];
            }
            tamanho--;
        }
        else {
            std::cout << "Indice invalido.\n";
        }
    }

    void mostrarLista() {
        std::cout << "Lista: ";
        for (int i = 0; i < tamanho; ++i) {
            std::cout << lista[i] << " ";
        }
        std::cout << std::endl;
    }

    void ordenarLista() {
        std::sort(lista, lista + tamanho);
        std::cout << "Lista ordenada.\n";
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

    // ... operações para ordenar a lista
};




int main()
{   
    vector<int> vectorLista1000(1000);
    MinhaLista SimpLista1000;
    MinhaListaDuplamenteEncadeada DupLista1000;
    vector<int> vectorLista5000(5000);
    MinhaLista SimpLista5000;
    MinhaListaDuplamenteEncadeada DupLista5000;
    vector<int> vectorLista10000(10000);
    MinhaLista SimpLista10000;
    MinhaListaDuplamenteEncadeada DupLista10000;
}

