import { MYDEMOPROJTemplatePage } from './app.po';

describe('MYDEMOPROJ App', function() {
  let page: MYDEMOPROJTemplatePage;

  beforeEach(() => {
    page = new MYDEMOPROJTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
