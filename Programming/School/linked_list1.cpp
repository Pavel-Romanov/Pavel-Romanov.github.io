#include <iostream>
#include <cstdlib>
using namespace std;

template<class T> struct linked_list
{
    struct node
    {
        node *next=NULL;
        T item;
    };

private:

    node *first = NULL;
    node *last = NULL;
    int mCount = 0;

    void add_after(node* n, T value)
    {
        node* nn = new node();
        nn->item = value;
        if(n->next==NULL)
        {
            n->next = nn;
            last=nn;
        }
        else
        {
            nn->next=n->next;
            n->next=nn;
        }
    }

public:

    int size(){return mCount;}

    linked_list()
    {
    }

    void add_last(T value)
    {
        if(first==NULL)
        {
            first=last=new node();
            first->item=value;
        }
        else {add_after(last, value);}
        mCount++;
    }

    T pop_first()
    {
        if(first==NULL)
        {
            cout<<"ERROR!";
            exit(-1);
        }

        T item = first->item;
        first = first->next;
        mCount--;
        return item;
    }

    void print()
    {
        for(node *p = first; p!=NULL; p=p->next)
        {
            cout<<p->item<<endl;
        }
    }
};

int main()
{
    linked_list<int> list;

    for(int i=1;i<10;i++)list.add_last(i);
    //list.print();
    while(list.size()!=0)
    {
        cout<<list.pop_first()<<' ';
    }
    cout<<endl;

}
