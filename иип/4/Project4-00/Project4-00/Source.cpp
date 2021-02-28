#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <cstdlib>
#include <string>

using namespace std;

class Student {
private:
    char* FIO;
    int size;
    int group;
    int progress[5];
public:
    Student() {

    }

    Student(const char* str) {
        size = strlen(str) + 1;
        FIO = new char[size];
        strcpy(FIO, str);
    }

    Student(const char* str, int gr) {
        size = strlen(str) + 1;
        FIO = new char[size];
        strcpy(FIO, str);
        group = gr;
    }

    Student(const char* str, int gr, int prog[]) {
        size = strlen(str) + 1;
        FIO = new char[size];
        strcpy(FIO, str);
        group = gr;
        for (int i = 0; i < 5; i++) {
            progress[i] = prog[i];
        }
    }


    void SetFIO(char* str) {
        size = strlen(str) + 1;
        FIO = new char[size];
        strcpy(FIO, str);
    }

    void SetGroup(int gr) {
        group = gr;
    }

    void SetProgress(int prog[]) {
        for (int i = 0; i < 5; i++) {
            progress[i] = prog[i];
        }
    }

    void ShowFIO() {
        cout << "Студент: ";
        printf("%s \t", FIO);
    }

    void ShowGroup() {
        cout << "Группа студента: " << group << "\t";
    }

    void ShowProgress() {
        cout << "Успеваемость студента:" << endl;
        for (int i = 0; i < 5; i++) {
            cout << "Оценок " << i + 1 << " - " << GetNumberOfMark(i) << " штук.";
        }
    }

    void ShowProgressAnalysis() {
        cout << "Средняя оценка студента: " << ProgressAnalysis() << "\t";
    }

    double ProgressAnalysis() {
        double summ = 0;
        double numb = 0;
        for (int i = 0; i < 5; i++) {
            summ += GetNumberOfMark(i) * i + 1;
            numb += GetNumberOfMark(i);
        }
        return (summ / numb);
    }

    char* GetFIO() {
        return FIO;
    }

    int GetGroup() {
        return group;
    }

    int* GetProgress() {
        return progress;
    }

    int GetNumberOfMark(int mark) {
        //mark--;
        if ((mark >= 0) && (mark < 5))
            return progress[mark];
        else cout << "Недопустимая оценка" << endl;
    }
};

bool DvoishnikDetect(Student* name[], int n) {
    bool check = 0;
    if (name[n]->GetNumberOfMark(2) > 0)
        check = 1;
    return check;
}

void ShowOne(Student* name[], int n) {
    name[n]->ShowFIO();
    name[n]->ShowGroup();
    name[n]->ShowProgressAnalysis();
    cout << "\n";
}

void SetRandomProgress(Student* name[], int n) {
    //maybe
}

int main()
{
    setlocale(LC_ALL, "rus");
    int n = 10;

    int prog[5] = { 0, 0, 0, 3, 2 };

    Student A(string("Путин В. В.").c_str(), 4282, prog);
    Student B(string("Тертых В. А.").c_str(), 4282, prog);
    Student C(string("Потылицын А.Ю.").c_str(), 4282, prog);
    Student D(string("Гарейшина А.А.").c_str(), 4282, prog);
    Student E(string("Поперечный Д.Х.").c_str(), 4282, prog);
    Student F(string("Нейфельд М.Д.").c_str(), 4282, prog);
    Student G(string("Букреев Л.В.").c_str(), 4282, prog);
    Student H(string("Алексеев Е.Е.").c_str(), 4282, prog);
    Student I(string("Дудь Ю.Л.").c_str(), 4282, prog);
    Student J(string("Вторушин В.В.").c_str(), 4282, prog);
    Student* list[] = { &A, &B, &C, &D, &E, &F, &G, &H, &I, &J };

    bool ProgrammWork = true;
    int menu;



    while (ProgrammWork) {
        system("cls");
        cout << "1 - Показать всех студентов" << endl;
        cout << "2 - Показать всех задолжниковІ" << endl;
        cout << "3 - Средняя успеваемость студента" << endl;
        cout << "4 - Оценки студента" << endl;
        cout << "5 - Изменить ФИО студента" << endl;
        cout << "6 - Изменить группу студента" << endl;
        cout << "7 - Изменить оценки студента°" << endl;
        cout << "8 - Завершить работу" << endl;
        //cout << "" << endl;
        cin >> menu;
        switch (menu) {
        case 1: {
            system("cls");
            cout << "Список студентов: " << endl;
            for (int i = 0; i < n; i++) {
                cout << " Студент №" << i + 1 << ":";
                ShowOne(list, i);
            }
            system("pause");
            break;
        }
        case 2: {
            system("cls");
            cout << "Список должников: " << endl;
            bool check = false;
            for (int i = 0; i < n; i++) {
                if (DvoishnikDetect(list, i) == true) {
                    ShowOne(list, i);
                    check = true;
                }
            }
            if (check == false) cout << "Должников не имеется" << endl;
            system("pause");
            break;
        }
        case 3: {
            system("cls");
            int numb;
            cout << "Введите номер студента";
            cin >> numb;
            list[numb]->ShowFIO();
            list[numb]->ShowGroup();
            list[numb]->ShowProgressAnalysis();
            system("pause");
            break;

        }
        case 4: {
            system("cls");
            int numb;
            cout << "Введите номер студента";
            cin >> numb;
            list[numb]->ShowFIO();
            list[numb]->ShowGroup();
            list[numb]->ShowProgress();
            system("pause");
            break;
        }
        case 5: {
            system("cls");
            int numb;
            char NewFIO[32] = {};
            cout << "Введите номер студента";
            cin >> numb;
            cout << "Введите новое ФИО: ";
            cin >> NewFIO;
            list[numb]->SetFIO(NewFIO);
            list[numb]->ShowFIO();
            list[numb]->ShowGroup();
            list[numb]->ShowProgressAnalysis();
            system("pause");
            break;
        }
        case 6: {
            system("cls");
            int numb;
            int NewGroup;
            cout << "Введите номер студента";
            cin >> numb;
            cout << "Введите новый номер группы: ";
            cin >> NewGroup;
            list[numb]->SetGroup(NewGroup);
            list[numb]->ShowFIO();
            list[numb]->ShowGroup();
            list[numb]->ShowProgressAnalysis();
            system("pause");
            break;
        }
        case 7: {
            system("cls");
            int numb;
            int NewGroup;
            cout << "Введите номер студента";
            cin >> numb;
            cout << "Введите новые оценки: ";
            cin >> NewGroup;
            list[numb]->SetGroup(NewGroup);
            list[numb]->ShowFIO();
            list[numb]->ShowGroup();
            list[numb]->ShowProgressAnalysis();
            system("pause");
            break;
        }
        case 8: {
            system("cls");
        }
        }
    }
    return 0;
}