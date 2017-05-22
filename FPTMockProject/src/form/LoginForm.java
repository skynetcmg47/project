package form;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts.action.ActionErrors;
import org.apache.struts.action.ActionForm;
import org.apache.struts.action.ActionMapping;
import org.apache.struts.action.ActionMessage;

import common.StringProcess;

public class LoginForm extends ActionForm {
	private String username,password,submit,notice;

	public String getNotice() {
		return notice;
	}

	public void setNotice(String notice) {
		this.notice = notice;
	}

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}


	public String getSubmit() {
		return submit;
	}

	public void setSubmit(String submit) {
		this.submit = submit;
	}
	@Override
	public ActionErrors validate(ActionMapping mapping, HttpServletRequest request) {
		ActionErrors actionErrors=new ActionErrors();
		if(StringProcess.notVaild(username)){
			actionErrors.add("usernameError",new ActionMessage("error.username"));
		}
		if(StringProcess.notVaild(password)){
			actionErrors.add("passwordError",new ActionMessage("error.password"));
		}
		return actionErrors;
	}
}
