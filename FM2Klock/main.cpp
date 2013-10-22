#include <iostream>
#include <fstream>
#include <dirent.h>

using namespace std;

void unlock(char* path)
{
	cout << "Unlocking " << path << " ...\n";
	ofstream file;
	file.open(path, ios::out | ios::in);
	file.seekp(ios::beg);
	file.write("FIGHTINGISMAGIC/",16);
	file.close();
}

int main()
{
    cout << "Fighting is Magic's FM2K locker" << endl << endl;

	DIR *dir;
	struct dirent *ent;
	if ((dir = opendir (".")) != NULL) {
	  /* print all the files and directories within directory */
	  while ((ent = readdir (dir)) != NULL) {
		string name = ent->d_name;
		if (name.find(".player") != string::npos || name.find(".stage") != string::npos || name.find(".demo") != string::npos || name.find(".kgt") != string::npos)
			unlock(ent->d_name);
	  }
	  closedir (dir);
	} else {
	  /* could not open directory */
	  perror ("");
	}

    cout << "\nFighting Is Magic game files locked\nEdit disabled." << endl;

    return 0;
}