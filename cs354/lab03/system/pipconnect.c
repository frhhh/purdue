/* pipconnect.c - pipconnect */

#include <xinu.h>

/*------------------------------------------------------------------------
 * pipconnect  --  Connect a pipe by setting the two process IDs
 *------------------------------------------------------------------------
 */
syscall	pipconnect(
	  pipid32	pip,		/* ID of pipe to connect	*/
	  pid32		end1,		/* ID of process 1	*/
	  pid32		end2		/* ID of process 2	*/
	)
{
	if (isbadpip(pip)) {
		return SYSERR;
	}
	
	pipptr = &piptab[pip];
	if (pipptr->pstate != PIPE_FREE) {
		return SYSERR;
	}
	pipptr->pstate = PIPE_CONNECTED;

	return OK;
}