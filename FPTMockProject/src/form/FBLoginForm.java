package form;

import org.apache.struts.action.ActionForm;

public class FBLoginForm extends ActionForm{
	String fbName,name,fbID;

	public String getFbID() {
		return fbID;
	}

	public void setFbID(String fbID) {
		this.fbID = fbID;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getFbName() {
		return fbName;
	}

	public void setFbName(String fbName) {
		this.fbName = fbName;
	}
}
