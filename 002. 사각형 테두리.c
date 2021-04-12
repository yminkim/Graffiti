#include <stdio.h>
 
int main() {
	int i, j, k;
	int ga = 10, se=5;

	for (i = 1; i <= se; i++) {
		for (j = 1; j <= ga; j++)
		{
			if (i == 1) {
				if (j == 1)
					printf("┌");
				else if (j == ga)
					printf("┐");
				else
					printf("─");
			}
			else if (i == se) {
				if (j == 1)
					printf("└");
				else if (j == ga)
					printf("┘");
				else
					printf("─");
			}

			else {
				if (j == 1 || j == ga)
					printf("│");
				else
					printf(" ");
			}

		}

		printf("\n");
	}
	
	
}
