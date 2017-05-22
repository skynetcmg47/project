package action;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.struts.action.Action;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionForward;
import org.apache.struts.action.ActionMapping;

import form.LoginForm;

public class LoginAction extends Action{

	@Override
	public ActionForward execute(ActionMapping mapping, ActionForm form,
			HttpServletRequest request, HttpServletResponse response)
			throws Exception {
		LoginForm loginForm = (LoginForm)form;
		String sUserName = loginForm.getUsername();
		String sPassword = loginForm.getPassword();
		//check login here...
		if(sPassword.equals("admin")&&sUserName.equals("admin"))
		{
			System.out.println("login success");
			//session.setAttribute("userName", sUserName);
			return mapping.findForward("success");
		}
		else
		{
			System.out.println("login fail");
			loginForm.setNotice("Sai tên đăng nhập hoặc mật khẩu. xin vui lòng thử lại !");
			return mapping.findForward("fail");
		}
		
	}
	
}
