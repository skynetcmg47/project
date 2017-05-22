package action;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.struts.action.Action;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionForward;
import org.apache.struts.action.ActionMapping;

import form.FBLoginForm;


public class LoginFBAction  extends Action{

	@Override
	public ActionForward execute(ActionMapping mapping, ActionForm form,
			HttpServletRequest request, HttpServletResponse response)
			throws Exception {
		FBLoginForm hl = (FBLoginForm)form;
		String fbName=request.getParameter("fbName");
		String fbID=request.getParameter("fbID");

		System.out.println("name:"+fbName+" id:"+fbID);
		
		return mapping.findForward("success");
	}
	
}
