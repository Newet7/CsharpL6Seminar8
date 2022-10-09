// Что не так с кодом

// const Double пи = 3.1415;
// int k__BackingField;
// void set_MyProperty(int value)
// {
//  k__BackingField = value;
// }
// int get_MyProperty()
// {
//  return k__BackingField;
// }
// int MyProperty { get; set; }

const double pi = 3.1415;
int kBackingField;
void Set.MyProperty(int value)
{
    kBackingField = value;
}
int Get.MyProperty()
{
    return kBackingField;
}
int MyProperty { Get; Set; }

// такой код вообще не работает!
