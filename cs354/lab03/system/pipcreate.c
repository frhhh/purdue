/* pipcreate.c - pipcreate, newpip */

#include <xinu.h>

local	pipid32	_newpip(void);

/*------------------------------------------------------------------------
 *  pipcreate  -  create a new pipe and return the ID to the caller
 *------------------------------------------------------------------------
 */
syscall pipcreate(void)
{
	intmask	mask;					/* saved interrupt mask			*/
	pipid32	pip;					/* pipe ID to return			*/

	mask = disable();

	if ((pip=_newpip()) == SYSERR) {
		restore(mask);
		return SYSERR;
	}

	struct pentry *pipptr;			/* ptr to pipe table entry		*/

	pipptr = &piptab[pip];
	pipptr->pstate = PIPE_USED;
	pipptr->powner = getpid();		/* initialize table entry		*/
	pipptr->prdsem = semcreate(0);	/* create reader semaphore 		*/
	pipptr->pwrsem = semcreate(PIPE_SIZ);	/* create writer semaphore		*/
	pipptr->pbufs = 0;				/* set buffer starting index	*/
	pipptr->pbufc = 0;				/* set buffer character count	*/

	restore(mask);
	return pip;
}

/*------------------------------------------------------------------------
 *  newpip  -  allocate an unused pipe and return its index
 *------------------------------------------------------------------------
 */
local	pipid32	_newpip(void)
{
	static	pipid32	nextpip = 0;	/* next pipe index to try		*/
	pipid32	pip;					/* pipe ID to return			*/
	int32	i;						/* iterate through # entries	*/

	for (i = 0; i < NPIPE; i++) {
		pip = nextpip++;
		if (nextpip >= NPIPE)
			nextpip = 0;
		if (piptab[pip].pstate == PIPE_FREE) {
			return pip;
		}
	}

	return SYSERR;
}
