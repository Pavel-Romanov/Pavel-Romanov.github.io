#include <iostream>
#include <bits/stdc++.h>

using namespace std;

class tictactoe
{
public:

    char choice[9] = {'1','2','3','4','5','6','7','8','9'};

    void field()
    {
        cout<<"-------------"<<endl;
        cout<<"| "<<choice[0]<<  " | " <<choice[1]<<  " | " <<choice[2]<< " |"<<endl;
        cout<<"-------------"<<endl;
        cout<<"| "<<choice[3]<<  " | "<<choice[4]<<  " | "<<choice[5]<<  " |"<<endl;
        cout<<"-------------"<<endl;
        cout<<"| "<<choice[6]<<  " | "<<choice[7]<<  " | "<<choice[8]<<  " |"<<endl;
        cout<<"-------------"<<endl;
    }

    bool insertx(char x )
    {
        if(x==choice[x-'0'-1])
        {
            choice[x-'0'-1]='X';
            return true;
        }
        return false;
    }

    bool inserty(char y )
    {
        if(y==choice[y-'0'-1])
        {
            choice[y-'0'-1]='O';
            return true;
        }
        return false;
    }
};

int main()
{
    tictactoe x;
    char x1, y1;
    x.field();
    for(int i=0 ; i<9 ; i++)
    {
        bool flag=false;
        while(flag==false)
        {
            cout<<"Player 1 : ";
            cin>>x1;
            flag=x.insertx(x1);
        }
        x.field();

        flag=false;
        while(flag==false)
        {
            cout<<"Player 2 : ";
            cin>>y1;
            flag=x.inserty(y1);
        }
        x.field();
    }
    x.field();


}
