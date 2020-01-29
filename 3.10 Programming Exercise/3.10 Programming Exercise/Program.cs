# include <iostream>
#define PI 3.1416
using namespace std;
int main()
{
    float radius, area, circumference;

    cout << "Please input the value of the radius: ";
    cin >> radius;

    circumference = 2 * PI * radius;
    area = PI * (radius * radius);

    cout << "The area of the circle is " << area << " and the circumference is "
        << circumference << '.' << endl;

    cout << endl;

    return 0;
}