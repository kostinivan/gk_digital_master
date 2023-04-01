#include "../vecstr.hpp"
#include "../vec_utils.hpp"

using namespace std;
bool cmdOptionExists(char** begin, char** end, const std::string& option)
{
    return find(begin, end, option) != end;
}

enum OperationMode{
    DEFAULT,
    INTERACTIVE
};

int main(int argc, char * argv[]){
    OperationMode mode;
    if (cmdOptionExists(argv, argv+argc, "-h")){
           cout << "This one will groom your vector of strings. \n"
                    "opt -d: \t By default behaviour this will generate a random vector of" 
                    "\n\t\t strings and groom it with max length of 3.\n\n";
            cout <<  "opt -i: \t In interactive mode this will ask you for max length, "
                    "\n\t\tvector length, and also elements" << endl;
        return 0;
    } else if (cmdOptionExists(argv, argv+argc, "-d")){
        cout << "Default mode has been choosen" << endl;
        mode = OperationMode::DEFAULT;
    } else if (cmdOptionExists(argv, argv+argc, "-i")){
        cout << "Interactive mode has been choosen" << endl;
        mode = OperationMode::INTERACTIVE;
    } else {
        cout << "Unrecognised options: " << argv+argc << " \n See using: \t -h" << endl;
    }

    vector<string> input_one;
    uint64_t max_length = 3;
    switch (mode)
    {
    case DEFAULT:
        input_one = vec_utils::generateVector(50);
        break;
    case INTERACTIVE:
        input_one = vec_utils::getVectorFromUser();
        cout << "Give the max length: ";
        cin >> max_length;
        break;
    default:
        break;
    }

    VectorGroomer vec_groomer = VectorGroomer(input_one, max_length);
    cout << "Input vector was: \n";
    vec_utils::printVector(input_one);
    cout << "Groomed vector is: \n";
    vec_utils::printVector(vec_groomer.get_result());
    return 0;
};